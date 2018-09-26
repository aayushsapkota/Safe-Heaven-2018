using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Safe_Heaven_2018.Models
{
	public class Progress
	{
		public int progressId { get; set; }
		[ForeignKey("Level")]
		public int levelId { get; set; }
		[ForeignKey("AspNetUsers")]
		public int Id { get; set; }
	}
}