using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GP.Models
{
    public class teamLeader
    {
        [Key]
        public int teamLeader_id { get; set; }
        public string teamLeader_password { get; set; }
    }
}