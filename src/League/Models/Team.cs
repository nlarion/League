using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace League.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string captain { get; set; }
        public int division_id { get; set; }
        public virtual ICollection <Player> Players { get; set; }
        public virtual Division Division { get; set; }
    }
}
