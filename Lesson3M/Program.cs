using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace Lesson3M
{
    internal class Program
    {

        //Ввод чисел. Стоп по Q.

//        static int i = 0;
        static int n = 3; // начальное число элементов в массиве
        static int mist = 0; // счетчик ошибок
        static bool mistf = false; // признак ошибки
        static string? v = "0"; // вариант обработки ошибки
        static bool flag = false;
        static string?[] arr = new string?[n];

        static void Main(string[] args)
        {

            Console.WriteLine($"\nВведите числа, чтобы заполнить массив\nПодтвердить ввод числа - Enter\nЗавершить ввод - Q");
             
            int i = 0;

            while (i < arr.Length)
            {
                string? p = Console.ReadLine();

                if (p.ToUpper() == "Q")
                {
                    for (int j = 0; j < i; j++)
                    {
                        PrintMass(j); //Вызов метод вывода массива по Q
                    }
                    break;
                }
                else
                {

                   MistInput(p, ref i); //Вызов метод проверки ввода и обработки ошибок

                    if (flag == true) { Environment.Exit(0); }
                    if (mistf == true) // исключение из массива ошибки ввода
                    {
                        i = i - 1;
                        mistf = false;
                    }
                    else
                    {
                        arr[i] = p;

                        if (i == arr.Length - 1) // Проверка необходимости расширение массива
                        {
                            GrowMass(i); //Вызов метод расширение массива
                        }

                    }
                }
                
                i++;
            }
        }

        static void MistInput(string p, ref int i) // Метод проверки ввода и обработки ошибок
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

                while (true)

                {
                    Console.WriteLine($"\nНажмите\n1-Очистить\n2-Продолжить\n3-Выйти");
                    v = Convert.ToString(Console.ReadLine());

                    switch (v)
                    {
                        case "1":
                            arr = new string?[arr.Length];
                            i = 0; //!!! int
                            Console.WriteLine($"1 Массив очищен");
                            continue;
                        case "2":
                            Console.WriteLine($"2 Продолжайте ввод:");
                            break;
                        case "3":
                            Console.WriteLine($"3 Выход");
                            Console.WriteLine($" Элементов всего: {arr.Length}, введено верно: {i}, ошибок: {mist}");
                            flag = true;
                            break;
                        default:
                            continue;
                    }
                    break; 
                }


            }

        }

        static void GrowMass(int i) //Метод расширение массива
        {
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
                    arr[k] = temp[k];  //запись временного массива в рабочий
                }
            }
        }
        static void PrintMass(int j)
        { 

             Console.WriteLine($" {arr[j]}");

        }
    }
}

