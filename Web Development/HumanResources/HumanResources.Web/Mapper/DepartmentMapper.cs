using HumanResources.Web.Models;
using HumanResources.Web.ViewModels;

namespace HumanResources.Web.Mapper;
public static class DepartmentMapper
{
	public static DepartmentViewModel  ToViewModel(this Department department)
	{
		return new DepartmentViewModel
		{
			Id= department.Id,
			Name= department.Name,
			Description= department.Description,
			EstablishedDate= department.EstablishedDate
		};
	}

	public static List<DepartmentViewModel> ToViewModel(this List<Department> departments)
	{
		return departments.Select(department => department.ToViewModel() ).ToList();
	}

	public static Department ToModel(this DepartmentViewModel departmentViewModel)
	{
		return new Department
		{
			Id= departmentViewModel.Id,
			Name= departmentViewModel.Name,
			Description= departmentViewModel.Description,
			EstablishedDate= departmentViewModel.EstablishedDate
		};
	}

	public static List<Department> ToModel(this List<DepartmentViewModel> departmentViewModels)
	{
		return departmentViewModels.Select(departmentViewModel => departmentViewModel.ToModel()).ToList();
		//return Employee.Select(employee => employeeViewModel.ToViewModel()).ToList();
	}
}
