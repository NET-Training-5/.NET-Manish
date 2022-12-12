class AnimeDetails
{
    string movieName;
    string genre;

    public string Author { get; set; }

    public string Chapters { get; set; }

    public string GetMovie(string mvn)
    {
        movieName = mvn;
        return movieName;
    }

    public string GetGenre(string gen)
    {
        genre = gen;
        return genre;
    }


}