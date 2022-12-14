class FileIO
{
    string folderPath = @"G:\gitCloning";
    public void CreateFile()
    {

        string fileName = "abc.txt";
        string fullPath = @$"{folderPath}\{fileName}";
        // File.Create(fullPath);
        File.WriteAllText(fullPath, "This is first text file");
        Console.WriteLine("File Created Successfully");
    }

    public void CreateDirectory()
    {
        string newFolderPath = folderPath + "\\testFolder";
        Directory.CreateDirectory(newFolderPath);
    }
}