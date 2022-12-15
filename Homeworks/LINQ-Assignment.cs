class LinqAssignment
{
    int[] numbers = new int[1000];
    public int[] InsertNumberInArray()
    {

        for (int i = 0; i < 1000; ++i)
        {
            numbers[i] = i + 1;
        }
        return numbers;

    }

    public void MultipleOf5and7()
    {
        var num = InsertNumberInArray();

        var multipleOf5and7 = num.Where(num => num % 5 == 0 && num % 7 == 0);

        foreach (int x in multipleOf5and7)
        {
            Console.Write(x + " ");
        }

    }

    public void LessThan100LastLetter0()
    {
        var num = InsertNumberInArray();

        var lessThan100andEndis0 = num.Where(num => num < 100 && num % 10 == 0);

        foreach (int x in lessThan100andEndis0)
        {
            Console.Write(x + " ");
        }
    }


}