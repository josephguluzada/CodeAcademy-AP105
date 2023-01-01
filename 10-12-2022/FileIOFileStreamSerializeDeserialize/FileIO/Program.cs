namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\asus\\Desktop\\AB102";
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            //directoryInfo.Create();
            //directoryInfo.Refresh();
            //directoryInfo.Delete();

            //foreach (var item in directoryInfo.GetDirectories())
            //{
            //    Console.WriteLine($"{item.Name} {item.FullName}");
            //}

            //foreach (var file in directoryInfo.GetFiles())
            //{
            //    Console.WriteLine($"{file.Name} {file.FullName} {file.LinkTarget} {file.CreationTime} {file.Attributes} {file.Directory} {file.LastAccessTime} {file.LastWriteTime}");
            //}


            FileInfo newFile = new FileInfo(path + "\\AB102.txt");

            string[] content = { "Salam", "AB102, necesiniz?", "Dersde" };

            if (!newFile.Exists)
            {
                newFile.Create().Close();
            }

            File.WriteAllLines(newFile.FullName, content);



            foreach (var file in directoryInfo.GetFiles())
            {
                Console.WriteLine(file.FullName);
                foreach (var line in File.ReadAllLines(file.FullName))
                {
                    Console.WriteLine(line);
                }
            }

            //foreach (var item in File.ReadAllLines("C:\\Users\\asus\\Desktop\\AB102\\Reflection task.txt"))
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}