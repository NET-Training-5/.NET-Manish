class main
{
    public static void Main()
    {
        // Assignment of 12th Dec

        Console.Write("Enter Anime ID: ");
        int id = int.Parse(Console.ReadLine());

        AnimeChild AC = new AnimeChild(id);
        var a = AC.GetId();


        Console.Write("Enter Anime Name: ");
        string anm = Console.ReadLine();
        var b = AC.GetMovie(anm);

        Console.Write("Enter Anime Genre: ");
        string genr = Console.ReadLine();
        var c = AC.GetGenre(genr);

        Console.Write("Enter Anime Author: ");
        var d = AC.Author = Console.ReadLine();

        Console.Write("Enter Anime Chapters: ");
        var e = AC.Chapters = Console.ReadLine();

        Console.WriteLine($"\tID: {a}\n\tAnime Name: {b}\n\tGenre: {c}\n\tAuthor: {d}\n\tChapters: {e}");
    }
}