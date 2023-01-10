using HumanResources.Web.Mapper;
using HumanResources.Web.Models;
using HumanResources.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HumanResources.Web.Controllers;

public class EmployeeController : Controller
{
	HRDbContext db;

	public EmployeeController(HRDbContext _db)
	{
		db = _db;
	}
	public async Task<IActionResult> Index()
	{
		var employees = await db.Employees.Include(e => e.Department).Include(e=>e.Designation).ToListAsync();
		var employeeViewModels = employees.ToViewModel();
		return View(employeeViewModels);
	}

	public async  Task<IActionResult> Add()
	{
		//var departments = db.Departments.ToList();
		//var departmentList = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
		//ViewData["departments"] = departmentList;

		//var designations = db.Designations.ToList();
		//var designationList = designations.Select(x=> new SelectListItem { Text=x.Name, Value=x.Id.ToString() });
		//ViewData["designations"] = designationList;

		var departments =await db.Departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToListAsync();
		ViewData["departments"] = departments;
		var designations = await db.Designations.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToListAsync();
		ViewData["designations"] = designations;
		//return View();

		return View();
	}

	[HttpPost]
	public IActionResult Add(EmployeeViewModel employeeViewModel)
	{
		var relativePath = SaveProfileImage(employeeViewModel.ProfileImage);
		employeeViewModel.ProfilePath = relativePath;
		var employee = employeeViewModel.ToModel();

		db.Employees.Add(employee);
		db.SaveChanges();

		return RedirectToAction("Index");
	}
	
	private string SaveProfileImage(IFormFile profileImage)
	{
		var fileName = profileImage.FileName;   //38b7feaa-39d3-4ead-aeeb-ee7dff72cd4a_person.jpg
		var uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
		var relativePath = $"/images/profiles/{uniqueFileName}";
		var currentAppPath = Directory.GetCurrentDirectory();
		var fullFilePath = Path.Combine(currentAppPath, $"wwwroot/{relativePath}");

		var stream = System.IO.File.Create(fullFilePath);
		profileImage.CopyTo(stream);

		return relativePath;
	}

	public async Task<IActionResult> Edit(int id)
	{
		//var department = db.Departments.ToList();
		//var departmentLis = department.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
		//ViewData["department"] = departmentLis;

		//var designation = db.Designations.ToList();
		//var designationLis = designation.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
		//ViewData["designation"] = designationLis;

		var department = await db.Departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToListAsync();
		ViewData["department"] = department;
		var designation = await db.Designations.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }).ToListAsync();
		ViewData["designation"] = designation;
		var employee = db.Employees.Find(id);
		return View(employee);
	}

	[HttpPost]
	public IActionResult Edit(Employee employee)
	{
		//var relativePaths = SaveProfileImage(employee.ProfileImage);
		//employee.ProfilePath = relativePaths;

		db.Employees.Update(employee);
		db.SaveChanges();

		return RedirectToAction("Index");
	}

	public IActionResult Delete(int? id)
	{
		if (id == null || db.Departments == null)
		{
			return NotFound();
		}
		var employee = db.Employees.Find(id);
		return View(employee);
	}

	[HttpPost]
	public async Task<IActionResult> Delete(Employee employee)
	{
		if (db.Employees== null)
		{
			return Problem("Entity set 'HRDbContext.Employees'  is null.");
		}
		if (employee != null)
		{
			db.Employees.Remove(employee);
		}

		await db.SaveChangesAsync();

		return RedirectToAction("Index");
	}
}