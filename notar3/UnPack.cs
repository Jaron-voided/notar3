namespace notar3;

class UnPack
{
    void UnpackNotar(NotTarFile notarFile)
    {
        if (notarFile.Header.Magic != 0x6e6f746172313730)
        {
            Console.WriteLine("Sorry, this is the wrong filetype!");
            return;
        }

        string[] directories = new String[];
        foreach (FileListItem file in notarFile.FileList)
        {
            var i = 0;
            string pathToFile = file.PathToFile;
            string[] parts = pathToFile.Split('/');
            string directoryName = parts[0];
            string fileName = parts[1];
            if (!directories.Contains(directoryName))
            {
                Directory.CreateDirectory(directoryName);)
            }

            using (FileStream fs = File.Create(pathToFile))
            {
                byte[] data = notarFile.Payload[i].rawData;
                fs.Write(data, 0, data.Length);
            }
            
        }
    
    }
}