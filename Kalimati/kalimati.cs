using System.Data;
class kalimati
{
    // public static string getFilePath = @"G:\gitCloning\Data";
    // string saveFilePath = @"G:\gitCloning\SaveData";


    List<variables> vegetables = new List<variables>();

    // File - parse
    public void ParseCsv()
    {
        var getFilePath = @"G:\gitCloning\Data\kalimati.csv";
        var csvLines = File.ReadAllLines(getFilePath);

        foreach (var row in csvLines.Skip(1))
        {
            var rowData = row.Split(",");
            var vegetable = new variables()
            {
                sn = int.Parse(rowData[0]),
                commodity = rowData[1],
                date = DateOnly.Parse(rowData[2]),
                unit = rowData[3],
                minimum = float.Parse(rowData[4]),
                maximum = float.Parse(rowData[5]),
                average = float.Parse(rowData[6])
            };
            vegetables.Add(vegetable);
        }
    }

    public void Queries()
    {
        var saveFilePath1 = @"G:\gitCloning\SaveData\Query1.csv";
        var saveFilePath2 = @"G:\gitCloning\SaveData\Query2.csv";

        var sastoTarkariharu = vegetables.Where(x => x.average < 10);
        var sastoTarkariharuStringified = sastoTarkariharu.Select(x => $"{x.sn}, {x.commodity}");
        File.WriteAllLines(saveFilePath1, sastoTarkariharuStringified);

        var tardedOn2013 = vegetables.Where(x => x.date == new DateOnly(2013, 6, 17) && x.minimum < 40);
        var query = tardedOn2013.Select(x => $"{x.sn},{x.commodity}");
        File.WriteAllLines(saveFilePath2, query);
    }

}