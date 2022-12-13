class FileIO
{
    public void CreateFile()
    {
        string folderPath = @"G:\gitCloning";
        string fileName = "abc.txt";
        string fullPath = @$"{folderPath}\{fileName}";
        File.Create(fullPath);
    }
}