using HumanResources.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.Web.Controllers;

public class EmployeeController : Controller
{
	HRDbContext db = new HRDbContext();

	public IActionResult Index()
	{
		var employees = db.Employees.ToList();

		return View(employees);
	}

	public IActionResult Add()
	{
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