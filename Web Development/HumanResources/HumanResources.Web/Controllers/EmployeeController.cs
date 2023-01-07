using HumanResources.Web.Models;
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
	public IActionResult Index()
	{
		var employees = db.Employees.Include(e => e.Department).Include(e=>e.Designation).ToList();

		return View(employees);
	}

	public IActionResult Add()
	{
		var departments = db.Departments.ToList();
		var departmentList = departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
		ViewData["departments"] = departmentList;

		var designations = db.Designations.ToList();
		var designationList = designations.Select(x=> new SelectListItem { Text=x.Name, Value=x.Id.ToString() });
		ViewData["designations"] = designationList;

		//var departments = db.Departments.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToList();
		//ViewData["departments"] = departments;
		//var designations = db.Designations.Select(x => new SelectListItem { Text = x.Name, Value = x.Name }).ToList();
		//ViewData["designations"] = designations;
		//return View();

		return View();
	}

	[HttpPost]
	public IActionResult Add(Employee employee)
	{
		var relativePath = SaveProfileImage(employee.ProfileImage);
		employee.ProfilePath = relativePath;
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

	public IActionResult Edit(int id)
	{
		var department = db.Departments.ToList();
		var departmentLis = department.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
		ViewData["department"] = departmentLis;

		var designation = db.Designations.ToList();
		var designationLis = designation.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });
		ViewData["designation"] = designationLis;
		var employee = db.Employees.Find(id);
		return View(employee);
	}

	[HttpPost]
	public IActionResult Edit(Employee employee)
	{
		var relativePaths = SaveProfileImage(employee.ProfileImage);
		employee.ProfilePath = relativePaths;

		db.Employees.Update(employee);
		db.SaveChanges();

		return RedirectToAction("Index");
	}

	public IActionResult Delete(int id)
	{
		var employee = db.Employees.Find(id);
		return View(employee);
	}

	[HttpPost]
	public IActionResult Delete(Employee employee)
	{
		db.Employees.Remove(employee);
		db.SaveChanges();

		return RedirectToAction("Index");
	}
}