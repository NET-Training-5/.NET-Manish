using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult EmployeeDetails()
    {
        Employee e1 = new Employee()
        {
            Name = "Manish KumarTamang",
            Sex = Gender.Male,
            Email = "manishlama731@gmail.com",
            JoinDate = new DateTime(2016, 7, 06),
            Designation = "Database Administrator Trainee",
            Department = "IT Department",
            Phone = "9849451903",
            Address = "Balkumari, Lalitpur"
        };


        Employee e2 = new Employee()
        {
            Name = "Neerajan Aryal",
            Sex = Gender.Male,
            Email = "neerajan3636@gmail.com",
            JoinDate = new DateTime(2015, 6, 07),
            Designation = "Database Administrator Intern",
            Department = "IT Department",
            Phone = "9812345678",
            Address = "Nepaltar, Kathmandu"
        };

        Employee e3 = new Employee()
        {
            Name = "Kusum Khatri",
            Sex = Gender.Female,
            Email = "kusum123@gmail.com",
            JoinDate = new DateTime(2014, 5, 08),
            Designation = "Data Analyst Intern",
            Department = "IT Department",
            Phone = "9812345678",
            Address = "Lubhu, Lalitpur"
        };

        Employee e4 = new Employee()
        {
            Name = "Sarfaroz Alam",
            Sex = Gender.Male,
            Email = "sarfaroz123@gmail.com",
            JoinDate = new DateTime(2013, 4, 09),
            Designation = "Accountant Intern",
            Department = "Account & Finance",
            Phone = "9823567867",
            Address = "Balkumari, Lalitpur"
        };

        Employee e5 = new Employee()
        {
            Name = "Bipina K.C",
            Sex = Gender.Female,
            Email = "bipinia123@gmail.com",
            JoinDate = new DateTime(2012, 3, 10),
            Designation = "HR",
            Department = "HR & Admin",
            Phone = "9823456789",
            Address = "Imadol, Lalitpur"
        };

        Employee e6 = new Employee()
        {
            Name = "Sarun Dangol",
            Sex = Gender.Male,
            Email = "sarun123@gmail.com",
            JoinDate = new DateTime(2011, 2, 11),
            Designation = "System Admin Trainee",
            Department = "System Department",
            Phone = "9812367897",
            Address = "Sunakothi, Lalitpur"
        };

        Employee e7 = new Employee()
        {
            Name = "Saugat Nepal",
            Sex = Gender.Male,
            Email = "saugat123@gmail.com",
            JoinDate = new DateTime(2010, 1, 12),
            Designation = "System Intern",
            Department = "System Department",
            Phone = "9878675645",
            Address = "Koteshor, Kathmandu"
        };


        List<Employee> employees = new List<Employee>() { e1, e2, e3, e4, e5, e6, e7 };
        return View(employees);
    }
}