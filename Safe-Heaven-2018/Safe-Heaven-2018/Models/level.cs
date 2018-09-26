using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Safe_Heaven_2018.Models
{
	public class Level
	{
        [Key]
		public int levelId { get; set; }
		public string levelName { get; set; }
		public string levelDescription { get; set; }
        
	}
}