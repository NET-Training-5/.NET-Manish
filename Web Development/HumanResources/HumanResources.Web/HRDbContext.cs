using HumanResources.Web.Models;
using Microsoft.EntityFrameworkCore;

public class HRDbContext: DbContext
{
	public DbSet<Employee> Employees { get; set; }
	public DbSet<Department> Departments { get; set; }
	public DbSet<Designation> Designations { get; set; }

	public HRDbContext(DbContextOptions<HRDbContext> options) : base(options)
	{

	}
	//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	//{
	//	optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=HumanResources; Integrated Security=true");
	//}
}