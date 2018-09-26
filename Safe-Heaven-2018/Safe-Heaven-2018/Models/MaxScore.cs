using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Safe_Heaven_2018.Models
{
	public class MaxScore
	{
        [Key]
		[ForeignKey("Player"),Column (Order = 0)]
		public int playerId { get; set; }
		public virtual Player Player { get; set; }

        [Key]
        [ForeignKey("Score"), Column(Order = 1)]
		public int scoreId { get; set; }
        public virtual Score Score { get; set; }


	}
}