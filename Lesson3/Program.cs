using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ввод чисел. Стоп по Q.

            Console.WriteLine($"\nВведите числа, чтобы заполнить массив\nПодтвердить ввод числа - Enter\nЗавершить ввод - Q");

            int n = 3; // начальное число элементов в массиве
            int mist = 0; // счетчик ошибок
            bool mistf = false; // признак ошибки
            string? v = "0"; // вариант обработки ошибки
            bool f = true; 
            bool flag = false;

            string?[] arr = new string?[n];

            for (int i = 0; i < arr.Length; i++)
            {
                string? p = Console.ReadLine();

                if (p.ToUpper() != "Q")
                {
                    try // обработка ошибки (ввод символа)
                    {
                        double d = Convert.ToDouble(p);
                    }
                    catch
                    {
                        mist++;
                        mistf = true;

                        Console.WriteLine($"Ошибка ввода");

                        while (f == true)

                        {
                            Console.WriteLine($"\nНажмите\n1-Очистить\n2-Продолжить\n3-Выйти");
                            v = Convert.ToString(Console.ReadLine());

                            switch (v)
                            {
                                case "1":
                                    arr = new string?[arr.Length];
                                    i = 0;
                                    Console.WriteLine($"1 Массив очищен");
                                    flag = true;
                                    continue;
                                case "2":
                                    Console.WriteLine($"2 Продолжайте ввод:");
                                    f = true;
                                    flag = false;
                                    break;
                                case "3":
                                    Console.WriteLine($"3 Выход");
                                    Console.WriteLine($" Элементов всего: {arr.Length}, введено верно: {i}, ошибок: {mist}");
                                    return;
                                default:
                                    continue;
                            }

                            if (flag == false)
                            { break; }
                        }


                    }

                    if (mistf == true) // исключение из массива ошибки ввода
                    {
                        i = i - 1;
                        mistf = false;
                    }
                    else
                    {
                        arr[i] = p;
                    }

                    if (i == arr.Length - 1) // расширение массива
                    {
                        string?[] temp = new string?[arr.Length * 2];

                        for (int k = 0; k < arr.Length; k++)
                        {
                            temp[k] = arr[k]; // запись старого массива во временный
                        }
                        int l = arr.Length;
                        arr = new string?[arr.Length * 2];
                        for (int k = 0; k < l; k++)
                        {
                            arr[k] = temp[k];  //запись старого массива во временный
                        }
                    }
                }

                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.WriteLine($" {arr[j]}");
                    }
                    break;
                }
            }
        }
    }
}

