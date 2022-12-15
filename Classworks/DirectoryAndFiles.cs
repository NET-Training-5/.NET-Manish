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
            string childFilePath = rootFolderPath + "\\Folder" + i;
            Directory.CreateDirectory(childFilePath);
            string fileName = $"{i}.txt";
            string fullPath = @$"{childFilePath}\{fileName}";
            File.WriteAllText(fullPath, $"I am in file {i}");
        }

    }
}