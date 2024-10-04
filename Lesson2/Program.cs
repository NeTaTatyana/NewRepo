namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {

//Среднее арифметическое

            Console.WriteLine("Вычисляем среднее арифметическое для 4 чисел");

            int n = 4;
            double[] arr = new double[n];

            Console.Write($"\nВвведите числа, нажмимайте Enter после ввода каждого :\n");

            int i = 0;
            double sum = 0;
            double p = 0;
            int f = 0;
            while (i < n)
            {
                try
                {
                    p = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода, повторите");
                    f = 1;              // признак неудачного ввода
                }

//                Console.WriteLine($"{i}"); //для проверки

                if (f != 1)             // выполняем только если был удачный ввод 
                {
                    arr[i] = p;
                    i++;
                    sum += p;
                }
                else
                {
                    f = 0;              // обнуляем признак
                }
            }

            double res = sum / n;

            Console.Write($"\nСреднее арифметическое чисел: {res}");


// Каталог пользователей, ввод сделала без цикла умышленно

            Console.WriteLine("\n\nЗадайте данные 3 пользователей");

            int nn = 3;
            string[][] sarr = new string[nn][];

            Console.Write($"\nВведите через пробел: Имя Месяц \nНажмите Enter после ввода данных каждого пользователя :\n");

            try
            {
                Console.Write($"\n1:");
                string? s1 = Console.ReadLine();
                sarr[0] = s1.Split(' ');
            }
            catch
            {
                Console.WriteLine("ошибка ввода");
            }
            try
            {
                Console.Write($"\n2:");
                string ? s2 = Console.ReadLine();
                sarr[1] = s2.Split(' ');
            }
            catch
            {
                Console.WriteLine("ошибка ввода");
            }
            try
            {
                Console.Write($"\n3:");
                string? s3 = Console.ReadLine();
                sarr[2] = s3.Split(' ');
            }
            catch
            {
                Console.WriteLine("ошибка ввода");
            }

//            Console.WriteLine(sarr[0][0]); //для проверки

            Console.Write($"\nДанные какого пользователя вывести? Введите номер от 1 до 3:");

            try
            {
            int j  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n {sarr[j-1][0]} {sarr[j-1][1]} ");
            }
            catch 
            {
                Console.WriteLine("Ошибка ввода, повторите");

            }
        }
    }
}
