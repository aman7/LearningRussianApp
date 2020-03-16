using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRussianApp.Models
{
    public class Verb
    {
        public int id { get; set; }
        public string engWord { get; set; }
        public string russWord { get; set; }
        public string p1 { get; set; }
        public string p2 { get; set; }
        public string p3 { get; set; }
        public string p4 { get; set; }
        public string p5 { get; set; }
        public string p6 { get; set; }

        public string ps1 { get; set; }
        public string ps2 { get; set; }
        public string ps3 { get; set; }
        public string ps4 { get; set; }


        public string f1 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public string f5 { get; set; }
        public string f6 { get; set; }

        public string status { get; set; }
        public DateTime reviewDate { get; set; }
    }
}
