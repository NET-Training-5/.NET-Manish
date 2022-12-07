class MainClass
{
    public static void Main()
    {
        menu m = new();
        method mth = new();

        // Calling  main_menu method to display Main Menu for user.
        m.main_menu();

        int ch = int.Parse(Console.ReadLine());
        do
        {
            switch (ch)
            {
                case 1:
                    // Storing user input numbers in arr variables
                    // Then passing it into GetMinMax Method
                    var arr = mth.GetArray();
                    mth.GetMinMax(arr);
                    break;
                case 2:
                    // Caling a function to get Symbol Pattern
                    mth.GetSymbolPattern();
                    break;
                case 3:
                    // Caling a function to get Number Pattern
                    mth.GetNumberPattern();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("!!!---INVALID INPUT---!!!\n!!!---PLEASE PROVIDE VALID INPUT---!!!");
                    break;
            }
            m.main_menu();
            ch = int.Parse(Console.ReadLine());
        }
        while (ch != 0);

    }
}