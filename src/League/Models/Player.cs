using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace League.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public virtual Team Team { get; set; }
    }
}
