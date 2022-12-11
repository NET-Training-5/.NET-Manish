
namespace PreBasic
{
    class Selection
    {
        public void Learn_switch()
        {

            Console.WriteLine("Enter your rashi: For e.g. 'Mesh', 'Tula', 'Brisha' ");
            Console.Write("Enter your rashi: ");
            string rashi = Console.ReadLine();

            switch (rashi)
            {
                case "Mesh":
                    Console.WriteLine("OUTPUT---> Mesh rashi initials are ka, kha...");
                    break;
                case "Tula":
                    Console.WriteLine("OUTPUT---> Tula rashi initials are Ga, Gha...");
                    break;
                case "Brisha":
                    Console.WriteLine("OUTPUT---> Brisha rashi initials are Ba, Bi...");
                    break;
                default:
                    Console.WriteLine("OUTPUT---> Unknown rashi");
                    break;
            }
            return;
        }

        public void if_else()
        {
            Console.Write("Enter Your Age: ");
            short age = Convert.ToInt16(Console.ReadLine());
            if (age > 18) // comparison operators >, <, <=, >=, !=, ==, &&, ||
            {
                Console.WriteLine("OUTPUT---> You are old. hahaha");
            }
            else
            {
                Console.WriteLine("OUTPUT---> You're still a kid. hahaha.");
            }
            return;
        }

        public void if_else_if()
        {
            Console.Write("Enter Your Age: ");
            short age = Convert.ToInt16(Console.ReadLine());
            if (age < 18) // comparison operators >, <, <=, >=, !=, ==, &&, ||
            {
                Console.WriteLine("OUTPUT---> You are child.");
            }
            else if (age < 40)
            {
                Console.WriteLine("OUTPUT---> You're adult.");
            }
            else if (age < 60)
            {
                Console.WriteLine("OUTPUT---> You are in your middle age.");
            }
            else
            {
                Console.WriteLine("OUTPUT---> You are old. Hahahaha");
            }
            return;
        }

        public void SelectionStatementsBody()
        {
            menu m = new();
            char choi = char.Parse(Console.ReadLine());
            switch (choi)
            {
                case 'A':
                    if_else();
                    break;
                case 'B':
                    if_else_if();
                    break;
                case 'C':
                    Learn_switch();
                    break;
                case 'O':
                    break;
                default:
                    Console.WriteLine("Invalid Input...\nPlease Enter Correct Value...");
                    break;
            }

            m.SelectionStatement_Menu();
            choi = char.Parse(Console.ReadLine());
        }
    }

}