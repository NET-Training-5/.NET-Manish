using HumanResources.Web.Enums;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Web.Models
{
	public class Benefit
	{
		public int Id { get; set; }
		public double Salary { get; set; }
		public double PerformanceBonus { get; set; }
		public double Allowance { get; set; }
		public DateTime Year { get; set; }
		public List<Employee> Employees { get; set; }


	}
}
