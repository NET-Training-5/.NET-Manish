using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult EmployeeDetails()
    {
        return View();
    }
}