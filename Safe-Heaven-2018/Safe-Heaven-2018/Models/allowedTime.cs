using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Safe_Heaven_2018.Models
{
    public class allowedTime
    {
        public int id { set; get; }

        [DataType(DataType.DateTime)]
        public DateTime time { get; set; }

        [Display(Name = "Player")]
        public int playerId { get; set; }

        [ForeignKey("playerId")]
        public virtual Player Players { get; set; }
    }
}