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
		db.Employees.Add(employee);
		db.SaveChanges();

		return RedirectToAction("Index");
	}

	public IActionResult Edit(int id)
	{
		var employee = db.Employees.Find(id);
		return View(employee);
	}

	[HttpPost]
	public IActionResult Edit(Employee employee)
	{
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