// 1 (Покормить) - добавляется 3 зерна и появляется 1 яйцо
// 2 (Забрать яйца) - яйца забираются сразу все
// При любом сделанном ходе (1,2,3) курица съдает 1 зерно


    namespace Lesson5_Play
    {

        internal class Program
        {

            static bool chickenstatus = true; //  курицы жива да/нет
            static int corn = 0; // количество зерен, 1 для 1-го хода;
            static int egg = 0; // количество собранных яиц, -1 для 1-го хода;E LfiE LfibE 
            static int step  = 0;
            static string stringchickenstatus = "жива";
            static int eggcount = 0;
            static bool end = false;
            static void Main(string[] args)
            {

                Console.WriteLine($"Кормите курицу и собирайте яйца \n ");
                Console.WriteLine($"1 - Покормить\n2 - Забрать яйца\n3 - Ничего не делать\n4 - Выйти \n");


                while (true)
                {

                stringchickenstatus = Live(chickenstatus);
                    Console.WriteLine($"Курица {stringchickenstatus}!   зерен: {corn}   яиц у курицы: {egg}   яиц собрано: {eggcount} \n");

                    while (true)
                    {
                        if (Int32.TryParse(Console.ReadLine(), out step))
                        {
                            if (step > 0 && step < 5)
                            {
                                break;
                            }
                        }
                        Console.WriteLine($"Ошибка, нажмите 1 или 2, 3 или 4");
                    }

                    DoStep(step, ref chickenstatus, ref corn, ref egg);
                    
                    if (end == true) 
                    {
                        Console.WriteLine($"Выход");
                        break;
                    }
                    if (chickenstatus == false)
                    {
                        Console.WriteLine($"Курицы больше нет\n\n");
                        break;
                    }
                }

            }

            static void DoStep(int stepm, ref bool chickenstatusm, ref int cornm, ref int eggm)
            {
                switch (stepm)
                {
                    case 1:
                    {
                        action1(ref cornm, ref eggm);
                        break;
                    }
                    case 2:
                    {
                        action2(ref eggm);
                        break;
                    }
                    case 3:
                    { 
                        break; 
                    }
                    case 4:
                    {
                        end = true;
                        break; 
                    }

                }

                cornm--;
                if (cornm <= 0)
                {
                chickenstatusm = false; 
                    return; 
                }
            //          eggm++; //если яйцо высиживается каждый ход, пока есть зерна


        }

        static string Live(bool x)
            {
                if (x == true)
                { return "жива"; }
                { return "не жива"; }
            }

            static void action1(ref int cornmm, ref int eggmm)
            {
                cornmm += 3;
                eggmm++; // если яйцо высиживается только в тот ход, когда кормят
            }

            static void action2(ref int eggmm)
            {
                if (eggmm > 0)
                {
                //                      eggm--;         // если собирать по одному
                //                      eggcount++;     // если собирать по одному
                eggcount += eggmm;   // если собирать все сразу
                eggmm = 0;         // если собирать все одному
                }
                else
                {
                    Console.WriteLine($"Забирать нечего");
                }
            }
                       
        }
}
