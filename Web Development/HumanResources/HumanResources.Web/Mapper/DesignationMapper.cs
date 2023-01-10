using HumanResources.Web.Models;
using HumanResources.Web.ViewModels;

namespace HumanResources.Web.Mapper;
public static class DesignationMapper
{
	public static DesignationViewModel  ToViewModel(this Designation designation)
	{
		return new DesignationViewModel
		{
			Id = designation.Id,
			Name= designation.Name,
			Description= designation.Description
		};
	}

	public static List<DesignationViewModel> ToViewModel(this List<Designation> designation)
	{
		return designation.Select(des => des.ToViewModel() ).ToList();
	}

	public static Designation ToModel(this DesignationViewModel designationView)
	{
		return new Designation
		{
			Id = designationView.Id,
			Name = designationView.Name,
			Description = designationView.Description
		};
	}

	public static List<Designation> ToModel(this List<DesignationViewModel> designationViewModels)
	{
		return designationViewModels.Select(designationViewModel => designationViewModel.ToModel()).ToList();
		//return Employee.Select(employee => employeeViewModel.ToViewModel()).ToList();
	}
}
