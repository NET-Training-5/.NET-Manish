using HumanResources.ApplicationCore.Enums;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Web.Models
{
	public class DepartmentViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime EstablishedDate { get; set; }


	}
}
