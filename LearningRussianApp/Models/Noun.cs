using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRussianApp.Models
{
    public class Noun
    {
        [Key]
        public int id { get; set; }
        public string engWord { get; set; }
        public string russWord { get; set; }
        public string gender { get; set; }
        public string r1 { get; set; }
        public string r2 { get; set; }
        public string r3 { get; set; }
        public string r4  { get; set; }
        public string r5   { get; set; }
        public string r6 { get; set; }
        public string r7 { get; set; }
        public string r8 { get; set; }
        public string r9 { get; set; }
        public string r10 { get; set; }
        public string answer { get; set; }
        public string status { get; set; }
        public DateTime reviewDate { get; set; }
    }
}
