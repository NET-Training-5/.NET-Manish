class main
{
    public static void Main()
    {
        LinqAssignment la = new();
        menu m = new();
        m.main_menu();
        int ch = int.Parse(Console.ReadLine());

        while (ch != 0)
        {
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Below are all the elements in Array:");
                    var num = la.InsertNumberInArray();
                    foreach (int x in num)
                    {
                        Console.Write(x + " ");
                    }
                    break;
                case 2:
                    Console.WriteLine("Below are all the elements which are multiples of 5 and 7:");
                    la.MultipleOf5and7();
                    break;
                case 3:
                    Console.WriteLine("Below are all the elements in which are less than 100 and Ends with 0:");
                    la.LessThan100LastLetter0();
                    break;
                default:
                    Console.WriteLine("Invalid Input, Please Insert Valid Input!!!");
                    break;
            }
            m.main_menu();
            ch = int.Parse(Console.ReadLine());
        }


        // // Assignment of 12th Dec

        // Console.Write("Enter Anime ID: ");
        // int id = int.Parse(Console.ReadLine());

        // AnimeChild AC = new AnimeChild(id);
        // var a = AC.GetId();


        // Console.Write("Enter Anime Name: ");
        // string anm = Console.ReadLine();
        // var b = AC.GetMovie(anm);

        // Console.Write("Enter Anime Genre: ");
        // string genr = Console.ReadLine();
        // var c = AC.GetGenre(genr);

        // Console.Write("Enter Anime Author: ");
        // var d = AC.Author = Console.ReadLine();

        // Console.Write("Enter Anime Chapters: ");
        // var e = AC.Chapters = Console.ReadLine();

        // Console.WriteLine($"\tID: {a}\n\tAnime Name: {b}\n\tGenre: {c}\n\tAuthor: {d}\n\tChapters: {e}");
    }
}