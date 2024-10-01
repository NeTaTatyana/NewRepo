namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Последовательно введите ваши данные");
            Console.Write("\nИмя:");
            string? i = Console.ReadLine();

            Console.Write("Фамилия:");
            string? f = Console.ReadLine();

            Console.Write("Отчество:");
            string? o = Console.ReadLine();

            Console.WriteLine($"\nПривет, {i} {f} {o}!");

            Console.WriteLine("\nВведите данные для вычисления");

            Console.Write("\nПервое число: ");
            double p1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Второе число: ");
            double p2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Действие ( + - * / ): ");
            string p = Console.ReadLine();

            string restext = (" ");

            switch (p)

            {
                case "+":
                    restext = ($"{p1 + p2}");
                    break;
                case "-":
                    restext = ($"{p1 - p2}");
                    break;
                case "*":
                    restext = ($"{p1 * p2}");
                    break;
                case "/":
                    if (p2 != 0)
                    {
                        restext = ($"{p1 / p2}");
                    }
                    else
                    {
                        restext = ($"Деление на ноль!");
                    }
                    break;
                default:
                    {
                        restext = ("Что-то пошло не так");
                        break;
                    }

            }

            Console.WriteLine($"Результат: {restext}");
            Console.WriteLine($"\nНажмите Enter, чтобы выйти");
            Console.ReadLine();
        }
    }
}
