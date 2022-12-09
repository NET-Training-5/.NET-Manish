class EntryPoint
{
    public static void Main()
    {
        Anime an = new();
        an.animeName = "Kimetsu No Yaiba";
        an.author = "Koyoharu Gotouge";
        an.Genre = "Shonen manga/Comic Category";
        an.PrintDetails();
    }
}