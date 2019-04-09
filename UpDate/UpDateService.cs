using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDate
{
    public class UpDateService
    {
        public List<FileInfo> LoadFilesRecursively(DirectoryInfo source, ref List<FileInfo> files)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
                LoadFilesRecursively(dir, ref files);
            files.AddRange(source.GetFiles());

            return files;
        }
        public List<DisplayImage> LoadFilesRecursively(string dir)
        {
            List<FileInfo> files = new List<FileInfo>();
            LoadFilesRecursively(new DirectoryInfo(dir), ref files);

            List<DisplayImage> displayFiles = files.Select(x => new DisplayImage()
            {
                Name = x.Name,
                Extension = x.Extension,
                Size = x.Length,
                FileInfo = x
            }).ToList();

            return displayFiles;
        }
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //var dirs = System.IO.Directory.GetDirectories(@"C:\Users\Robbe\Pictures\Camera - Copy");
        //        //foreach(string dir in dirs)
        //        //{
        //        //    var subdirs = System.IO.Directory.GetDirectories(dir);
        //        //    foreach (string subdir in subdirs)
        //        //    {
        //        //        FixDates(subdir);
        //        //    }
        //        //}


        //        //CopyFilesRecursively(new DirectoryInfo(@"C:\Users\Robbe\Pictures\Camera - Copy"), @"C:\Users\Robbe\Pictures\kill me");
        //        FixDates(@"C:\Users\Robbe\Pictures\kill me");

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        Console.Read();
        //    }
        //}

        public static void CopyFilesRecursively(DirectoryInfo source, string destination)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyFilesRecursively(dir, destination);
            foreach (FileInfo file in source.GetFiles())
            {

                if (!File.Exists(Path.Combine(destination, file.Name)))
                {
                    file.CopyTo(Path.Combine(destination, file.Name));
                    Console.WriteLine($"NEW {file.Name}");
                }
                else Console.WriteLine($"OLD {file.Name}");
            }
        }

        public static void FixDates(string dir)
        {
            var filenames = System.IO.Directory.GetFiles(dir);
            foreach (string file in filenames)
            {
                try
                {
                    string fileName = $"{file.Split('\\').Last()}";
                    Console.WriteLine(fileName);

                    //Try to get takenAt date
                    DateTime takenAt = new DateTime();
                    bool takenAtSuccess = false;
                    var directories = ImageMetadataReader.ReadMetadata(file);
                    var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                    if (subIfdDirectory != null)
                    {
                        try
                        {
                            takenAt = subIfdDirectory.GetDateTime(ExifDirectoryBase.TagDateTimeOriginal);
                            takenAtSuccess = true;
                        }
                        catch (Exception e)
                        {
                        }
                    }
                    Console.WriteLine($"Original:");
                    Console.WriteLine($"  - Created at: {File.GetCreationTime(file)}");
                    Console.WriteLine($"  - Modified at: {File.GetLastWriteTime(file)}");
                    if (takenAtSuccess) Console.WriteLine($"  - Taken at: {takenAt}");
                    else Console.WriteLine($"  - Taken at: unknown");


                    //Check name for date
                    fileName = fileName.Substring(0, fileName.LastIndexOf('.'));
                    if (fileName.StartsWith("Screenshot"))
                    {
                        fileName = fileName.Split('_')[1];
                    }
                    else if (fileName.Contains(' '))
                    {
                        fileName = fileName.Substring(0, fileName.LastIndexOf(' '));
                    }
                    else if (fileName.StartsWith("IMG_"))
                    {
                        fileName = fileName.Substring(4);
                    }
                    else if (fileName.EndsWith("_x264"))
                    {
                        fileName = fileName.Replace("_x264", "");
                    }

                    string[] formats = { "yyyyMMdd_HHmm", "yyyyMMdd_HHmmss", "yy-MM-dd HH-mm-ss", "yyyyMMdd-HHmmss" };

                    DateTime titleDate = new DateTime();

                    bool titleSuccess = DateTime.TryParseExact(fileName, formats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out titleDate);

                    //First use title - always the most accurate
                    if (titleSuccess)
                    {
                        File.SetLastWriteTime(file, titleDate);
                        File.SetCreationTime(file, titleDate);
                        Console.WriteLine($"  - Date used (title): {titleDate}");
                    }

                    //If available - use takenAt (also always accurate)
                    else if (takenAtSuccess)
                    {
                        File.SetLastWriteTime(file, takenAt);
                        File.SetCreationTime(file, takenAt);
                        Console.WriteLine($"  - Date used (takenAt): {takenAt}");
                    }

                    //Use the oldest date between modified and created
                    else
                    {
                        DateTime modified = File.GetLastWriteTime(file);
                        DateTime created = File.GetCreationTime(file);

                        DateTime oldest = new DateTime();
                        if (modified < created) oldest = modified;
                        else oldest = created;

                        //oldest = new DateTime(2015, 4, 16, 14, 22, 0);

                        File.SetLastWriteTime(file, oldest);
                        File.SetCreationTime(file, oldest);


                        Console.WriteLine($"  - Date used (oldest): {oldest}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();
            }
        }
    }
}
