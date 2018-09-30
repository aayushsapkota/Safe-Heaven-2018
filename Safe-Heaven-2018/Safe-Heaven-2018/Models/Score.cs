using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Safe_Heaven_2018.Models
{
	public class Score
	{   
        [Key]
		public int scoreId { get; set; }
		public int scoreValue { get; set; }

		//[ForeignKey("Player"), Column(Order = 0)]
		//public int playerId { get; set; }
  //      public virtual Player Player { get; set; }

  //      [ForeignKey("Level"), Column(Order = 1)]
		//public int levelId { get; set; }
  //      public virtual Level Level { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Level> Levels { get; set; }


    }
}