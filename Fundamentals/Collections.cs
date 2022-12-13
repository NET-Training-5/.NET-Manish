class Collection
{
    /*
    void LearnList()
    {
        List<byte> numbers = new List<byte>();
        numbers.Add(23);
        numbers.Add(231);
        numbers.Add(237);
        numbers.Add(123);
        numbers.Add(223);

        numbers.Remove(237);

        List<string> names = new List<string>() { "Bishnu", "Ram", "Hari" };

        foreach (var i in names)
        {
            Console.WriteLine(i);
        }
    }
    */

    void LearnDictionary()
    {
        Dictionary<string, long> countryPopulation = new();
        countryPopulation.Add("Nepal", 9823416789123);
        countryPopulation.Add("India", 345678909876);
        countryPopulation.Add("China", 1234523458908765432);
        countryPopulation.Add("USA", 12345678908798765);
        countryPopulation.Add("Canada", 12345678976543);

        countryPopulation.Remove("China");

        foreach (var i in countryPopulation)
        {
            Console.WriteLine(i);
        }
    }
}