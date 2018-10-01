using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Safe_Heaven_2018.Models
{
    public class Progress
    {
        [Key]
        public int progressId { get; set; }

        //[ForeignKey("Level")]
        //public int levelId { get; set; }
        //public virtual Level Level { get; set; }

       
    }
}