using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson7
{
    internal class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {

                string directorypath = @"SomeDir";

                DirectoryInfo DirectoryInf = new DirectoryInfo(directorypath);
                if (!DirectoryInf.Exists)
                {
                    DirectoryInf.Create();
                }


                Console.WriteLine($"Список файлов в папке {directorypath}:");

                foreach (var FileInfo in DirectoryInf.GetFiles())
                {
                    Console.WriteLine(FileInfo.Name);
                }


                Console.WriteLine($"\nВведите имя файла, если его нет, то создадим:\n");

                string? userfilename = Console.ReadLine();


                string? filename = @userfilename;
                string filepath = directorypath + @"\" + filename;

                Console.WriteLine($"\nНапишите, чтобы добвить и нажмите ввод:\n");

                string? texttofile = Console.ReadLine();

                File.AppendAllText(filepath, texttofile);

                Console.WriteLine($"\nCодержимое файла:\n");

                string? fileText = File.ReadAllText(filepath);
                Console.WriteLine(fileText);

                bool endFlag = false;

                while (endFlag == false)
                    
                    {
                    Console.WriteLine($"\n<1> Продолжить <0> Выход\n");

                    if (Int32.TryParse(Console.ReadLine(), out int key))
                        {

                            switch (key)
                            {
                                case 0:

                                    System.Environment.Exit(1);
                                    break;

                                case 1:
                                    
                                    endFlag = true;
                                    break;
                                 
                            }
  
                    }
                    
                }

            }
        }
    }
}
