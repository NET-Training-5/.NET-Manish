using HumanResources.ApplicationCore.Enums;
using HumanResources.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HumanResources.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			List<Employee> employees = new List<Employee>();
			// Fetch Data From DB
			//SqlConnection connection;
			//SqlCommand command;
			//SqlDataReader reader;
			string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HumanResources_Test;"
			+ "Integrated Security=true";

			// Provide the query string with a parameter placeholder.
			string queryString =
				"SELECT * from dbo.Employee";

			// Create and open the connection in a using block. This
			// ensures that all resources will be closed and disposed
			// when the code exits.
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// Create the Command and Parameter objects.
				SqlCommand command = new SqlCommand(queryString, connection);

				// Open the connection in a try/catch block.
				// Create and execute the DataReader, writing the result
				// set to the console window.
				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					while (reader.Read())
					{
						var emp = new Employee
						{
							Id = reader.GetInt32(0),
							Name = reader.GetString(1),
							Address = reader.GetString(2),
							Gender = (Gender)reader.GetInt32(3),
							Dob = reader.GetDateTime(4),
						};
						employees.Add(emp);
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				return View(employees);
			}
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}