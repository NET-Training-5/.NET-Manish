class DirectoryAndFiles
{
    string folderPath = @"G:\gitCloning";


    public void CreateDirectoriesAndFiles()
    {
        for (int i = 1; i < 11; i++)
        {
            string newFolderPath = folderPath + "\\Folder" + i;
            Directory.CreateDirectory(newFolderPath);
        }

    }
}