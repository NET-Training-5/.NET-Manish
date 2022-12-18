// LINQ - Language Integrated Query

class LINQ
{
    int[] numbers = { 3, 4, 6, 8, 1, 3, 4, 51, 45, 67, 12, 34 };

    void LearnToQuery()
    {
        // List all even numbers from "numbers" array
        // Below solution is called Imperative Method or way
        List<int> evens = new List<int>();
        foreach (var num in numbers)
        {
            if (num % 2 == 0)
            {
                evens.Add(num);
            }
        }

        // Below solution is called Declarative Method or way
        var evenNumbers = numbers.Where(num => num % 2 == 0);

        // List all odd numbers which are divisible by 3
        var oddNumbers = numbers.Where(num => num % 2 == 1 && num % 3 == 0);

        // List multiples of 5 and 7 from "numbers"
        // List all items less than 100 and ends with 0's from "numbers"

        void PrintValues<T>(IEnumerable<T> items, string label)
        {
            Console.Write($"\n{label}");
            foreach (var item in items)
            {
                Console.WriteLine(item + " ");
            }
        }
        // Print squares of all items in numbers array
        // Projections
        var squares = numbers.Select(x => x * x);
        PrintValues(squares, "Squares: ");

        // Print square root of all items less than 50
        var squareRoots = numbers.Where(x => x < 50).Select(x => Math.Sqrt(x).ToString("N2"));
        // var squareRoots = numbers.Where(x => x < 50).Select(x => Math.Round(Math.Sqrt(x), 2)); <-- This can Also be Done...
        PrintValues(squareRoots, "Square Roots Less Than 50: ");

        // Expression Syntax
        var sqRoots1 = from x in numbers
                       where x < 50
                       select Math.Round(Math.Sqrt(x), 2);

        // Sort Numbers
        var numbersSorted = numbers.Order();

        string[] countries = { "Nepal", "India", "USA", "Australia", "Japan", "UAE", "China" };

        /* Create an array containing 20 country names. Query this collection to answer following:
         1. List all countries starting with letter N.
         2. List all countries which have length of 4 or less.
         3. Convert all countries to uppercase.
         */

        // List 5 items skipping first two
        var fiveItems = numbers.Skip(2).Take(5);
        PrintValues(fiveItems, "Skip-Take");

        // Check if any item is even number
        var isThereAnyEvenNumber = numbers.Any(x => x % 2 == 0);
        Console.WriteLine($"Any Even: {isThereAnyEvenNumber}");

        // Check if all items are even numbers
        var isAllNumbersEven = numbers.All(x => x % 2 == 0);
        Console.WriteLine($"All Even: {isAllNumbersEven}");

    }
    public void LearnToQueryOnObjectCollection()
    {
        Person p1 = new();
        p1.fullName = "Manish Kumar Tamang";
        p1.gender = 'M';
        p1.height = 170.23f;

        Person p2 = new() { fullName = "Ram Basnet", gender = 'M', height = 160.34f };
        Person p3 = new() { fullName = "Gita Basnet", gender = 'F', height = 164.34f };
        Person p4 = new() { fullName = "Ganesh Joshi", gender = 'M', height = 161.34f };
        Person p5 = new() { fullName = "Rita Basnet", gender = 'F', height = 180.38f };
        List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

        // people.Add(p1);
        // people.Add(p2);
        // people.Add(p3);
        // people.Add(p4);
        // people.Add(p5);

        // List All females
        var females = people.Where(x => x.gender == 'F');

        // List All Males is ascending order of their height
        // Contextual keywords (from, where, orderby, select)
        var males = from x in people
                    where x.gender == 'M'
                    orderby p1.height
                    select x;
    }

}