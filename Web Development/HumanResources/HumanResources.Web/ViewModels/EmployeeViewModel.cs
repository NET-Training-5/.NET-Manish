using HumanResources.ApplicationCore.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResources.Web.ViewModels
{
	public class EmployeeViewModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "We need your name")]
		[MinLength(2, ErrorMessage = "Please enter at least 2 letters")]
		public string Name { get; set; }
		public string? Address { get; set; }

		[DataType(DataType.EmailAddress)]
		[Required(ErrorMessage = "We need your email id")]
		public string Email { get; set; }
		public Gender Gender { get; set; }

		[Display(Name = "Date Of Birth")]
		public DateTime? Dob { get; set; }

		[Display(Name = "Join Date")]
		public DateTime JoinDate { get; set; }

		[Display(Name = "Department")]
		public string? DepartmentName { get; set; }
		public int DepartmentId { get; set; }
		public string? DesignationName { get; set; }

		[Display(Name = "Upload Your Avatar")]
		public IFormFile ProfileImage { get; set; }
		public string? ProfilePath { get; set; }
		public int DesignationId { get; set; }
		//public Benefit Benefit { get; set; }
		//public int BenefitId { get; set; }
	}
}
