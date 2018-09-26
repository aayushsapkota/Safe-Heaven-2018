using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace Safe_Heaven_2018.Models
{
	public class MaxScore
	{
		[ForeignKey("Player")]
		public int playerId { get; set; }
		public Player Player { get; set; }
		[ForeignKey("Score")]
		public int scoreId { get; set; }

	}
}