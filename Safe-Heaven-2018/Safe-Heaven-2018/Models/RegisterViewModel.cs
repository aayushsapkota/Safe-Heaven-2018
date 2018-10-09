using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Safe_Heaven_2018.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Please Enter Full Name")]
		public string FullName { get; set; }

		[Required(ErrorMessage = "Please Enter the valid Username")]
		[Display(Name = "Please Enter Username")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Please enter a valid email address")]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required(ErrorMessage ="Please Enter the Password")]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage ="Confirm password section need to be filled")]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}
}