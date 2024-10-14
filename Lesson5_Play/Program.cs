
using System;
using System.Diagnostics.Metrics;
using System.Drawing;

// 1 (Покормить) - добавляется 3 зерна и появляется 1 яйцо
// 2 (Забрать яйца) - яйца забираются сразу все
// При любом сделанном ходе (1,2,3) курица съдает 1 зерно


namespace Lesson5_Play
{

    internal class Program
    {

        static bool chickenstatus = true; //  курицы жива да/нет
        static int zerno = 0; // количество зерен, 1 для 1-го хода;
        static int egg = 0; // количество собранных яиц, -1 для 1-го хода;E LfiE LfibE 
        static int hotkey = 0;
        static string stringstatus = "жива";
        static int eggcount = 0;
        static bool end = false;
        static void Main(string[] args)
        {

            Console.WriteLine($"Кормите курицу и собирайте яйца \n ");
            Console.WriteLine($"1 - Покормить\n2 - Забрать яйца\n3 - Ничего не делать\n4 - Выйти \n");


            while (true)
            {

                stringstatus = Live(chickenstatus);
                Console.WriteLine($"Курица {stringstatus}!   зерен: {zerno}   яиц у курицы: {egg}   яиц собрано: {eggcount} \n");

                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out hotkey))
                    {
                        if (hotkey > 0 && hotkey < 5)
                        {
                            break;
                        }
                    }
                    Console.WriteLine($"Ошибка, нажмите 1 или 2, 3 или 4");
                }

                //               DoHotkey(hotkey,out chickenstatus,out zerno,out y);

                DoHotKey(hotkey, ref chickenstatus, ref zerno, ref egg);

            }

        }

        static void DoHotKey(int hotkeym, ref bool chickenstatusm, ref int zernom, ref int eggm)
        {
            switch (hotkeym)
            {
                case 1:
                    {
                        zernom += 3;
                      eggm++; // если яйцо высиживается только в тот ход, когда кормят
                      break; 
                    }
                case 2:
                    if (eggm>0)
                    {
//                      ym--;         // если собирать по одному
//                      ycount++;     // если собирать по одному
                      eggcount += eggm;   // если собирать все сразу
                      eggm = 0;         // если собирать все одному
                        break; }
                    else
                    {
                      Console.WriteLine($"Забирать нечего");
                      break;
                    }
                case 3:
                    { break; }
                case 4:
                    Console.WriteLine($"Выход");
                    System.Environment.Exit(1);
                    //end = true;
                    { break; }
            }
          zernom--;

            if (zernom <= 0) {
                Console.WriteLine($"Курицы больше нет\n\n"); 
                System.Environment.Exit(1); }   
//          { chickenstatusm = false; return; }
//          ym++; //если яйцо высиживается каждый ход, пока есть зерна


        }
       
        static string Live(bool x)
        {
            if (x == true)
            { return "жива"; }
            { return "не жива"; }
        }
}
}
