
using System;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Lesson5_Play
{

    internal class Program
    {

        static bool k = true; //  курицы жива да/нет
        static int z = 0; // количество зерен, 1 для 1-го хода;
        static int y = 0; // количество собранных яиц, -1 для 1-го хода;E LfiE LfibE 
        static int hod = 0;
        static string sk = "жива";
        static int ycount = 0;
        static bool end = false;
        static void Main(string[] args)
        {

            Console.WriteLine($"Кормите курицу и собирайте яйца \n ");
            Console.WriteLine($"1 - Покормить\n2 - Забрать яйца\n3 - Ничего не делать\n4 - Выйти \n");


            while (true)
            {
               
                sk = Live(k);
                Console.WriteLine($"Курица {sk}!   зерен: {z}   яиц у курицы: {y}   яиц собрано: {ycount} \n");

                while (true)
                {
                    if (Int32.TryParse(Console.ReadLine(), out hod))
                    {
                        if (hod > 0 && hod < 5)
                        {
                            break;
                        }
                    }
                    Console.WriteLine($"Ошибка, нажмите 1 или 2, 3 или 4");
                }

                //               DoHod(hod,out k,out z,out y);
                
                DoHod(hod, ref k, ref z, ref y);
                if (end == true)
                {    Console.WriteLine($"Выход");
                     break; 
                }
                if (k == false)
                {
                    Console.WriteLine($"Курицы больше нет\n\n");
                    break;
                }
            }

        }

        static void DoHod(int hodm, ref bool km, ref int zm, ref int ym)
        {
            switch (hodm)
            {
                case 1:
                    { zm += 3;
                      ym++; // если яйцо высиживается только в тот ход, когда кормят
                      break; 
                    }
                case 2:
                    if (ym>0)
                    {
//                      ym--;         // если собирать по одному
//                      ycount++;     // если собирать по одному
                      ycount += ym;   // если собирать все сразу
                      ym = 0;         // если собирать все одному
                        break; }
                    else
                    {
                      Console.WriteLine($"Забирать нечего");
                      break;
                    }
                case 3:
                    { break; }
                case 4:
                    end = true;
                    { break; }
            }
          zm--;
          if (zm <= 0)    
          { km = false; return; }
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
