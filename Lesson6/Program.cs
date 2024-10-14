namespace Lesson6
{


    // 1 (Покормить) - добавляется 3 зерна и появляется 1 яйцо
    // 2 (Забрать яйца) - яйца забираются сразу все
    // При любом сделанном ходе (1,2,3) курица съдает 1 зерно


    namespace Lesson6_Play
    {

        internal class Program
        {

            static bool chickenstatus = true; //  курицы жива да/нет
            static int hotkey = 0;
            static int chickennumber = 0;
            static int eggcount = 0;

                                        //  {   0//порядковый номер ,
                                        //      1//статус(жива/мертва),
                                        //      2//зерно,
                                        //      3//яйца
                                        //  }

            static int[,] chickens = { {1, 1, 3, 0 }, {2, 1, 3, 0 }, { 3, 1, 3, 0} };


            static void Main(string[] args)
            {

                Console.WriteLine($"Кормите куриц и собирайте яйца \n ");
                Console.WriteLine($"1 - Покормить\n2 - Забрать яйца\n3 - Ничего не делать\n4 - Выйти \n");


                while (true)
                {

                    for (int l = 0; l < 3; l++)
                    {

                        Console.WriteLine($"Курицы:  {chickens[l, 0]} - {chickens[l, 1]}   зерен: {chickens[l, 2]}   яиц у курицы: {chickens[l, 3]}");
                    }

                    Console.WriteLine($"Всего яиц собрано: {eggcount}");

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

                    DoHotKey(hotkey);

                }

            }

            static void DoHotKey(int hotkeym)
            {
                switch (hotkeym)
                {
                    case 1:
                        {
                            Console.WriteLine($"Выберите номер курицы: 1, 2 или 3");
                            while (true)
                            {
                                if (Int32.TryParse(Console.ReadLine(), out chickennumber))
                                {
                                    if (chickennumber > 0 && chickennumber < 4 && chickens[chickennumber - 1, 1]!=0)
                                    {
                                        chickens[chickennumber-1, 2] += 3;  // добавлям зерно
                                        chickens[chickennumber-1, 3]++;     // появляется яйцо
                                        break;
                                    }
                                    Console.WriteLine($"Ошибка, выберите номер живой курицы");
                                }
                            } break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Выберите номер курицы: 1, 2 или 3");
                            while (true)
                            {
                                if (Int32.TryParse(Console.ReadLine(), out chickennumber))
                                {
                                    if (chickennumber > 0 && chickennumber < 4 && chickens[chickennumber - 1, 1] != 0)
                                    {

                                        if (chickens[chickennumber - 1, 3] > 0)
                                        {
                                            eggcount += chickens[chickennumber - 1, 3];   
                                            chickens[chickennumber - 1, 3] = 0;         
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Забирать нечего");
                                            break;
                                        }
                                     }
                                        Console.WriteLine($"Ошибка, выберите номер живой курицы");
                                }
                            } break;
                        }
                    case 3:
                        { break; }
                    case 4:
                        Console.WriteLine($"Выход");
                        System.Environment.Exit(1);
                        { break; }
                }

 //               chickens[0, 2]--;
 //               chickens[1, 2]--;
 //               chickens[2, 2]--;

                for (int l = 0; l < 3; l++)
                {
                    chickens[l, 2]--; //минус зерно у каждой курицы за каждый ход 

                    if (chickens[l, 2] <= 0)
                    {
                        chickens[l, 1] = 0; // статус жизни сгорает
                        chickens[l, 2] = 0; // чтобы зерно не продолжало вычитатся у мертвых
                        chickens[l, 3] = 0; // яйца сгорают
                    }
                }

                if (chickens[0, 1] <= 0  && chickens[1, 1] <= 0 && chickens[2, 1] <= 0)
                {
                    Console.WriteLine($"Нет больше ни одной курицы\n\n");
                    System.Environment.Exit(1);
                }

            }

        }
    }
}
