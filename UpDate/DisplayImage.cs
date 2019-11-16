using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDate
{
    public class DisplayImage
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Size { get; set; }
        public DateTime Date { get; set; }
        public FileInfo FileInfo { get; set; }
    }
}
