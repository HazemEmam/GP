using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP.Models
{
    public class projectIdea
    {
        [Key]
        public int id { get; set; }
        public string project_name { get; set; }
        public string project_description { get; set; }
        public virtual ICollection<teamLeader> teamleader { get; set; }
    }
}