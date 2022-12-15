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
    }
}