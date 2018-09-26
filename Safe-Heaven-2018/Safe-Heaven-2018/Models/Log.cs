using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Safe_Heaven_2018.Models
{
    public class Log
    {
        public int logId { get; set; }
        public long logtime { get; set; }
        public string logDecsription { get; set; }
        [ForeignKey("user")]
        public int UserId { get; set; }
    }
}