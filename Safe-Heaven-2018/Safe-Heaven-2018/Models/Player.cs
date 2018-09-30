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
        public string playerUsername { get; set; }
		public TimeSpan playerPlayTime { get; set; }
		public DateTime playerDate { get; set; }
        
        


	}
}