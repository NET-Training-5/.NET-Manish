using HumanResources.Web.Models;
using HumanResources.Web.ViewModels;

namespace HumanResources.Web.Mapper;
public static class EmployeeMapper
{
	public static EmployeeViewModel  ToViewModel(this Employee employee)
	{
		return new EmployeeViewModel
		{
			Id = employee.Id,
			Name = employee.Name,
			Address = employee.Address,
			Gender = employee.Gender,
			Dob = employee.Dob,
			Email = employee.Email,
			JoinDate = employee.JoinDate,
			DesignationId = employee.DesignationId,
			DesignationName = employee.Designation.Name,
			DepartmentId = employee.DepartmentId,
			DepartmentName = employee.Department.Name,
			ProfilePath = employee.ProfilePath
		};
	}

	public static List<EmployeeViewModel> ToViewModel(this List<Employee> employees)
	{
		return employees.Select(employee => employee.ToViewModel() ).ToList();
	}

	public static Employee ToModel(this EmployeeViewModel employeeViewModel)
	{
		return new Employee
		{
			Id = employeeViewModel.Id,
			Name = employeeViewModel.Name,
			Address = employeeViewModel.Address,
			Gender = employeeViewModel.Gender,
			Dob = employeeViewModel.Dob,
			Email = employeeViewModel.Email,
			JoinDate = employeeViewModel.JoinDate,
			DesignationId = employeeViewModel.DesignationId,
			DepartmentId = employeeViewModel.DepartmentId,
			ProfilePath = employeeViewModel.ProfilePath
		};
	}

	public static List<Employee> ToModel(this List<EmployeeViewModel> employeeViewModel)
	{
		return employeeViewModel.Select(employeeViewModel => employeeViewModel.ToModel()).ToList();
		//return Employee.Select(employee => employeeViewModel.ToViewModel()).ToList();
	}
}
