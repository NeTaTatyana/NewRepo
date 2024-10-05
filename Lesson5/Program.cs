namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        //Вывод простого числа по порядковому номеру                
        
        {
        Console.WriteLine("Введите порядковый номер простого числа: "); //2 - первое простое число

            int pn = 0;

            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out pn))
                {
                    if ( pn >= 1)
                    { 
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Введите номер >=1");
                    } 
                        
                }
                else
                {
                    Console.WriteLine($"Ошибка ввода, повторите");
                }
            }


            //int pn = int.Parse(Console.ReadLine());
            int i = 0;
                int pcount = 0;
              

                    for (i = 2; i <= 1000; i++)
                    {

                        if (i >= 1000)
                        {
                        Console.WriteLine($"Слишком большое число )))");
                        return;
                        }
                        else
 
                        if (isSimple(i))
                        {
                            pcount++;

                        if (pcount == pn) 
                        { break; }                        }
                    }
              
        
                Console.Write($"Прстое число:{i}");

      
        static bool isSimple(int N) //Проверка простое число или нет
            {
                for (int i = 2; i <= (N / 2); i++) // цикл до N/2
                {
                    if (N % i == 0) // проверка есть остаток или нет
                    { return false; }
                }
                return true;
            }
        }
    }
}
