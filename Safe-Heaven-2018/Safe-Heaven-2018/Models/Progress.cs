using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Safe_Heaven_2018.Models
{
    public class Progress
    {
        [Key]
        public int progressId { get; set; }

        [ForeignKey("Level")]
        public int levelId { get; set; }
        public virtual Level level { get; set; }


        [ForeignKey("ApplicationUser")]
        public int Id { get; set; }
        public virtual ApplicationUser aspNetUsers { get; set; }
    }
}