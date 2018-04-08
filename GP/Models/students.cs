using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP.Models
{
    public class students
    {
        [Key]
        public int student_id { get; set; }
        public string student_name { get; set; }
        public int student_ssn { get; set; }
        public float student_gpa { get; set; }
        public string transcript { get; set; }
        public virtual ICollection<teamLeader> teamleader { get; set; }
    }
}