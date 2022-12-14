class DirectoryAndFiles
{
    string folderPath = @"G:\gitCloning";


    public void CreateDirectoriesAndFiles()
    {
        string rootFolderPath = folderPath + "\\RootFolder";
        Directory.CreateDirectory(rootFolderPath);
        for (int i = 1; i < 11; i++)
        {
            string childFolderPath = rootFolderPath + "\\Folder" + i;
            Directory.CreateDirectory(childFolderPath);
        }

    }
}