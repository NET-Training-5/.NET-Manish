class method
{

    public float[] GetArray()
    {
        Console.Write("Enter the size of array: ");
        int sz = int.Parse(Console.ReadLine());
        int i;

        float[] n = new float[sz];
        for (i = 0; i < sz; i++)
        {
            Console.Write("Enter the number: ");
            n[i] = float.Parse(Console.ReadLine());
        }

        return n;
    }
    public void GetMinMax(params float[] nums)
    {

        float[] num = nums;
        var max = num.Max();
        var min = num.Min();
        Console.WriteLine($"The minimum value among given numbers is: {min}");
        Console.WriteLine($"The maximum value among given numbers is: {max}");

    }

    public void GetSymbolPattern()
    {
        Console.WriteLine("Below is the desired Symbol Pattern: ");
        for (int i = 1; i < 6; i++)
        {
            Console.Write("\t\t");
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");

            }
            Console.WriteLine();
        }
    }

    public void GetNumberPattern()
    {
        Console.WriteLine("Below is the desired Number Pattern: ");
        for (int i = 1; i < 7; i++)
        {
            Console.Write("\t\t");
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }

    public (short, short) FindMinMax(params short[] numbers)
    {
        short min = short.MaxValue, max = short.MinValue;

        foreach (var num in numbers)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }

        }
        return (min, max);
    }
}