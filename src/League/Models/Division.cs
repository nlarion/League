using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace League.Models
{
    [Table("Divisions")]
    public class Division
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string skill { get; set; }
        public int capacity { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
