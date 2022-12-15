using System;

class Variable
{
    void LearnAboutVariables()
    {
        // Static: C#, Java, C++, C --> Also Known as compiled language
        // Dynamic: JS, Ruby, Python

        // Datatypes
        // Numbers
        // Integral
        byte a = 23;
        short b = 32242;
        ushort b1 = 32242;
        int c = 34759835;
        uint c1 = 34759835;
        long d = 353153252353;
        ulong d1 = 353153252353;

        // Floating point
        float e = 42234.3453f;
        double f = 32424324.45646;
        decimal g = 423524525.3453245235235345m;

        // Strings
        string h = "Manish";
        Char i = 'M';

        // Boolean
        bool? j = null;

        // Datetime
        DateTime dob = DateTime.Now;
        DateOnly chunabDay = DateOnly.MinValue;
        TimeOnly meetingToday = TimeOnly.MinValue;

        // Arrays
        // One dimensional
        byte[] personaAges = new byte[5];
        personaAges[0] = 89;
        personaAges[1] = 9;
        personaAges[2] = 18;
        personaAges[3] = 67;
        personaAges[4] = 23;

        var x = personaAges[2];

        byte[] personAges1 = { 89, 9, 18, 67, 23 };

        // Write an array to hold student names
        string[] names = { "Ram", "Shyam", "Lakhan", "Pranish" };


        // Multi-dimensional
        // 3    8   9
        // 8    7   3
        int[,] mat = new int[2, 3];
        // mat[0][0] = 3;
        // mat[0][1] = 8;
        // mat[0][2] = 9;
        // mat[1][0] = 8;
        // mat[1][1] = 7;
        // mat[1][2] = 3;

        int[,] table = { { 3, 8, 9 }, { 8, 7, 3 } };

        // Jagged Array
        // 2    4   7
        // 1    5
        // 9    8   4   5

        short[][] items = new short[3][];
        items[0] = new short[] { 2, 4, 7 };
        items[1] = new short[] { 1, 5 };
        items[2] = new short[] { 9, 8, 4, 5 };



    }
}