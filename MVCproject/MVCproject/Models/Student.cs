using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCproject.Models
{
	public class Student
	{

		public int StudentID { get; set; }
		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		public string Age { get; set; }
		public bool IsFullTimeStudent { get; set; }
		public campus campus  { get; set; }
		public EnrolledSubject EnrolledSubject { get; set; }

	}
}