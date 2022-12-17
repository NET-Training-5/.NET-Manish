class LinqAssignment
{

    string[] countries = { "USA", "Japan", "Arab", "Nepal", "Switzerland",
                            "New Zealand", "Brazil", "Ghana", "Morocco", "Argentina",
                            "France", "Netherland", "Canada", "Nigeria", "UK", "Spain",
                            "Germany", "Australia", "UAE", "Russia" };

    public void GetAllCountries()
    {
        DisplayValues(countries, "List Of All Countries: \n");
    }

    public void GetCountriesStartingWithN()
    {
        var getCountries = from x in countries
                           where x.StartsWith("N")
                           select x;

        DisplayValues(getCountries, "List Of Countries Which Has Starting letter N:\n");
    }

    public void GetCountriesLessOrEqualThan4()
    {
        var c = from x in countries
                where x.Length < 5
                select x;

        DisplayValues(c, "List of Countries whose Length is less or equal to 4:\n");
    }

    public void GetCountriesToUpperCase()
    {
        var upper = countries.Select(x => x.ToUpper());

        DisplayValues(upper, "List of all Countries after converting to uppercase:\n");
    }

    void DisplayValues<T>(IEnumerable<T> elements, string label)
    {
        Console.Write($"\n{label}");
        foreach (var x in elements)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();

    }











    // int[] numbers = new int[1000];
    // public int[] InsertNumberInArray()
    // {

    //     for (int i = 0; i < 1000; ++i)
    //     {
    //         numbers[i] = i + 1;
    //     }
    //     return numbers;

    // }

    // public void MultipleOf5and7()
    // {
    //     var num = InsertNumberInArray();

    //     var multipleOf5and7 = num.Where(num => num % 5 == 0 && num % 7 == 0);

    //     DisplayValues(multipleOf5and7);

    // }

    // public void LessThan100LastLetter0()
    // {
    //     var num = InsertNumberInArray();

    //     var lessThan100andEndis0 = num.Where(num => num < 100 && num % 10 == 0);

    //     DisplayValues(lessThan100andEndis0);
    // }




}