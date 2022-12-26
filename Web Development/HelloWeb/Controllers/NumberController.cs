using Microsoft.AspNetCore.Mvc;

public class NumberController : Controller
{
    public IActionResult MTable() //   /number/greet
    {
        return View();
    }

    public IActionResult MultiplicationTable(int n)
    {
        return View(n);
    }

    public IActionResult MultiplicationTableFromTo(int from, int to)
    {

        return View((from, to));
    }
}