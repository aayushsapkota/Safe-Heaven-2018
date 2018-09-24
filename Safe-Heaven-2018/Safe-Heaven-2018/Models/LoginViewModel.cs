using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Safe_Heaven_2018.Models
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Please Enter the Username")]
		[Display(Name = "Email")]
		[EmailAddress]
		public string Email { get; set; }

		[Required(ErrorMessage = "Please Enter the Password")]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[Display(Name = "Remember me?")]
		public bool RememberMe { get; set; }
	}

}