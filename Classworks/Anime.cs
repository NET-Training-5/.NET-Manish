class Anime
{
    public string author;
    private string genre;

    public string animeName { get; set; }

    public string Genre { set { genre = value; } }

    public void PrintDetails()
    {
        var details = $"Anime: {animeName}\nAuthor: {author}\nGenre: {genre}";
        Console.WriteLine(details);
    }
}