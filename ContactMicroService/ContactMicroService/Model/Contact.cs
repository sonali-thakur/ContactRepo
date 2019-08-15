using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactMicroService.Model
{
	/// <summary>
	/// COntact Model class
	/// </summary>
	public class Contact
	{
		/// <summary>
		/// class property
		/// </summary>
		[Key]
		public int ContactId { get; set; }

		/// <summary>
		/// class property
		/// </summary>
		[Required(ErrorMessage = "Please Enter First Name."),MaxLength(50)]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		/// <summary>
		/// class property
		/// </summary>
		[Required(ErrorMessage = "Please Enter Last Name."), MaxLength(50)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		/// <summary>
		/// class property
		/// </summary>
		[Required(ErrorMessage = "Please Enter Email Address.")]
		[Display(Name = "Email Address")]
		[RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",ErrorMessage = "Please Enter Correct Email Address")]
		public string Email { get; set; }

		/// <summary>
		/// class property
		/// </summary>
		[Required(ErrorMessage = "Please Enter Phone Number.")]
		[StringLength(10,ErrorMessage ="",MinimumLength =10)]
		[Display(Name = "Phone Number")]
		[DataType(DataType.PhoneNumber)]
		//[RegularExpression(@"[^0-9]", ErrorMessage = "Invalid Phone number")]
		//[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Invalid Phone number")]
		public string PhoneNumber { get; set; }

		/// <summary>
		/// class property
		/// </summary>
		[Required]
		public bool Status { get; set; }
	}
}
