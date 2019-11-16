using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace UpDate
{
    public class UpDateService
    {

        public enum DateType { CREATED, TAKEN, MODIFIED};

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
                Date = x.LastWriteTime,
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

        public void CopyFilesRecursively(DirectoryInfo source, string destination)
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

        public void FixDates(List<string> files, List<DateType> datesToChange, ImageNameConfig imageNameConfig = null, DateTime? hardCodedDate = null)
        {
            Console.Clear();
            //Zowel datum van file als name getten
            //Naar priority date kijken voor welke ge moet pakken (de oudste)
            //datesToChange alteren
            for (int k = 0; k < files.Count; k++)
            {
                string file = files[k];
                DateTime now = DateTime.Now;
                DateTime nameDate = now;
                try
                {
                    //Get date from name
                    if(imageNameConfig != null)
                    {
                        string[] formats = imageNameConfig.DateFormats.ToArray();
                        for (int i = 0; i < imageNameConfig.Scenarios.Count; i++)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file);

                            Scenario scenario = imageNameConfig.Scenarios[i];
                            if(scenario.Conditions.Any(x => x.Compile()(fileName))){
                                for (int j = 0; j < scenario.Actions.Count; j++)
                                {
                                    Action action = scenario.Actions[j];
                                    fileName = Regex.Replace(
                                        fileName,
                                        Regex.Escape(action.OldValue),
                                        action.NewValue.Replace("$", "$$"),
                                        RegexOptions.IgnoreCase
                                    );
                                }
                            }

                            DateTime temp;
                            bool titleSuccess = DateTime.TryParseExact(fileName, formats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out temp);
                            if (titleSuccess)
                            {
                                nameDate = temp;
                                break;
                            }
                        }
                    }

                    //Get date from file
                    DateTime takenDate = now;
                    DateTime createdDate = now;
                    DateTime modifiedDate = now;
                    DateTime mediaCreatedDate = now;
                    
                    modifiedDate = File.GetLastWriteTime(file);
                    createdDate = File.GetCreationTime(file);

                    var directories = ImageMetadataReader.ReadMetadata(file);
                    var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                    if (subIfdDirectory != null)
                    {
                        try
                        {
                            DateTime temp = subIfdDirectory.GetDateTime(ExifDirectoryBase.TagDateTimeOriginal);
                        }
                        catch (Exception e)
                        {
                        }
                    }

                    DateTime earliest = new List<DateTime> { nameDate, createdDate, takenDate, modifiedDate }.Min();
                    if (hardCodedDate != null) earliest = hardCodedDate ?? earliest;

                    if (earliest.Ticks == now.Ticks)
                    {
                        Console.WriteLine($"{k}: {File.GetLastWriteTime(file)} -> BAD \t\t\t\t: {Path.GetFileName(file)}");
                        continue;
                    }
                    Console.WriteLine($"{k}: {File.GetLastWriteTime(file)} -> {earliest}: \t\t{Path.GetFileName(file)}");
                    File.SetLastWriteTime(file, earliest);
                    File.SetCreationTime(file, earliest);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{k}: {File.GetLastWriteTime(file)} -> ERROR: \t\t{Path.GetFileName(file)}");
                }
            }
        }
    }
}