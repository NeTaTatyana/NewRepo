using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Lesson7
{
    internal class Program
    {

        //static string? fileText = "";

        static void Main(string[] args)
        {
            //            Console.WriteLine("Hello, World!");



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
            string filepath = directorypath+ @"\" + filename;

            Console.WriteLine($"\nНапишите, чтобы добвить и нажмите ввод:\n");

            string? texttofile = Console.ReadLine();

            //Console.WriteLine($"Повторим:{texttofile}");

            //            File.AppendAllText(String, String)

            // дозапись в конец файла
            File.AppendAllText(filepath, texttofile);

            Console.WriteLine($"\nCодержимое файла:\n");

            string? fileText = File.ReadAllText(filepath);
            Console.WriteLine(fileText);


        }
    }
}
