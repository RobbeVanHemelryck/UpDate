using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDate
{
    public class ImageNameConfig
    {
        public ImageNameConfig()
        {
            DateFormats = new List<string>();
            Scenarios = new List<Scenario>();
        }
        public List<string> DateFormats { get; set; }
        public List<Scenario> Scenarios { get; set; }
    }
}
