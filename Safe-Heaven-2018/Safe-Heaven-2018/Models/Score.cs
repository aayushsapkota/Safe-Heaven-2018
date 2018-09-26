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
		public int scoreId { get; set; }
		public int scoreValue { get; set; }
		[ForeignKey("Player")]
		public int playerId { get; set; }
		[ForeignKey("Level")]
		public int levelId { get; set; }

	}
}