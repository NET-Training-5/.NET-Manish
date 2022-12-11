using System;
using PreBasic;
class EntryPoint
{
    public static void Main()
    {

        // menu m = new();
        // m.main_menu();
        // byte ch = byte.Parse(Console.ReadLine());

        // while (ch != 0)
        // {
        //     switch (ch)
        //     {
        //         case 1:
        //             Loops lp = new();
        //             m.loop_menu();
        //             lp.looping_body();
        //             break;
        //         case 2:
        //             Selection sel = new();
        //             m.SelectionStatement_Menu();
        //             sel.SelectionStatementsBody();
        //             break;
        //         case 3:
        //             assign1 a1 = new();
        //             a1.AssignObj1();
        //             a1.AssignObj2();
        //             break;
        //         case 0:
        //             break;
        //         default:
        //             Console.WriteLine("Invalid Input...\nPlease provide valid input!!!");
        //             break;


        //     }
        //     m.main_menu();
        //     ch = byte.Parse(Console.ReadLine());
        // }


        // byte age = 23;
        // string name = "Ram";
        // string m = $"{name} is {age} years old"; // String Interpolation
        // Console.WriteLine(m);

        // Method m = new();
        // m.Print();
        // m.Print("I am Manish and I am god!!!");
        // m.GetMessage();
        // m.GetCovidResult("No");
        // var sum = m.AddS(23.5, 24.5);
        // Console.Write("Enter 1st Number: ");
        // int x = int.Parse(Console.ReadLine());
        // Console.WriteLine();
        // Console.Write("Enter 2nd Number: ");
        // int y = int.Parse(Console.ReadLine());
        // Console.WriteLine();
        // Console.Write("Enter 3rd Number: ");
        // int z = int.Parse(Console.ReadLine());
        // Console.WriteLine();

        // float avg = m.Average(x, y, z, 2, 3, 4);
        // Console.WriteLine("Average = " + avg);

        //         Person person1 = new();
        //         person1.fullName = "Manish Kumar Tamang";
        //         person1.dob = new DateTime(1999, 08, 22);
        //         person1.address = "Kathmandu";
        //         person1.gender = 'M';
        //         person1.weight = 70.5f;
        //         person1.height = 63.6f;

        //         var z = person1.GetAge();
        //         var y = person1.FindBMI();
        //         Console.WriteLine($"Age is: {z:N0} and BMI is {y}");
        // Vehicle car1 = new();
        // car1.Brand = "Tata";
        // car1.Model = "Nexon EV";
        // car1.PrintDetails();

        FiFa worldcup2018 = new();
        worldcup2018.host = "Russia";
        worldcup2018.year = new DateTime(2018, 2, 3);
        worldcup2018.winner = "France";
        worldcup2018.teams = new string[] { "France", "Germany", "Brazil" };

        FiFa worldcup2022 = new("Qatar");
        FiFa worldcup2002 = new("Qatar", new DateTime(2002, 1, 1), "Nepal", new string[] { "France", "Germany" });

        FiFa.Groups = 10;

        Selection sl = new(); // Can't be initialized object without referencing namespace...



    }
}