class AnimeChild : AnimeDetails, IAnimeID
{

    public AnimeChild(int ids)
    {
        id = ids;
    }

    int id;
    public int GetId()
    {
        var anime_id = id;
        return anime_id;
    }

}