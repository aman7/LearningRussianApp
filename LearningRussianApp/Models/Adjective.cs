using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningRussianApp.Models
{
    public class Adjective
    {
        [Key]
        public int id { get; set; }
        public string engWord { get; set; }
        public string russWord { get; set; }
        public string mas { get; set; }
        public string fem { get; set; }
        public string neu { get; set; }
        public string plu { get; set; }
        public string answer { get; set; }
        public string status { get; set; }
        public DateTime reviewDate { get; set; }
        public string testcolumn { get; set; }
    }
}
