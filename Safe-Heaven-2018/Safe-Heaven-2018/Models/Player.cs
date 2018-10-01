using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Safe_Heaven_2018.Models
{
    public class Player
    {
        [Key]
        public int playerId { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public DateTime Date = DateTime.Now;


        public virtual ICollection<Score> Scores { get; set; }



    }
}
