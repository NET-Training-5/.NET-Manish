class FiFa
{
    public static byte Groups = 8;
    public string host;
    public DateTime year;
    public string winner;
    public string[] teams;

    // Default Constructor
    public FiFa()
    {

    }

    // Parameterized Constructor
    public FiFa(string h)
    {
        host = h;
    }

    public FiFa(string h, DateTime y, string w, string[] tms)
    {
        host = h;
        year = y;
        winner = w;
        teams = tms;
    }

    // Garbage Collection
    // Calls Destructor automatically, flushes out memories
}