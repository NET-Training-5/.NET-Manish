class DirectoryAndFiles
{


    public void CreateDirectoriesAndFiles()
    {
        string rootFolderPath = @"G:\gitCloning\RootFolder";
        // for (int i = 1; i < 11; i++)
        // {
        //     string childFolderPath = rootFolderPath + "\\Folder" + i;
        //     Directory.CreateDirectory(childFolderPath);


        // }

        for (int i = 1; i < 11; i++)
        {
            string fullPath = rootFolderPath + "\\Folder" + i;
            Directory.CreateDirectory(fullPath);
            string fileName = $"{i}.txt";
            string childFilePath = @$"{fullPath}\{fileName}";
            File.WriteAllText(childFilePath, $"I am in file {i}");
        }

    }
}