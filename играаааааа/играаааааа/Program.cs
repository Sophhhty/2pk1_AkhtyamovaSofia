//using System;
namespace играаааааа
{
    internal class Program
    {
        static int Health_P = 30;
        static int hero_dmg = 5;
        static int Health_F = 15;
        static int enemy_dmg = 5;
        static int steps = 0;
        static int buffstep = 5;
        static int kol = 10;
        static string[,] map = new string[25, 25];
        static string enemy = "F";
        static string aid = "A";
        static string hero = "X";
        static string buff = "B";
        static int playerX = 12;
        static int playerY = 12;
        static void Main(string[] args)
        {
            //while (true)
            //{

            Console.Write("Нажмите Enter, чтобы начать новую игру");
            ConsoleKey answer = Console.ReadKey(true).Key;
            Console.Clear();
            if (answer == ConsoleKey.Enter)
            {

                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        map[i, j] = ".";
                    }
                    Console.Write("");
                }
                GenerateMap();
            }

            //else
            //{
            //    Console.WriteLine("Нельзя прочитать клавишу, попытайтесь ещё");
            //    Thread.Sleep(1000);
            //}

            for (int i = 0; Health_P > 0; i++)
            {

                if (kol <= 0)
                {
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Direction();
                    if (map[playerX, playerY] == enemy)
                    {
                        Fight();
                    }
                    if (map[playerX, playerY] != aid)
                    {
                        Healing();
                    }
                    if (map[playerX, playerY] != buff)
                    {
                        Buff();
                    }

                    UpdateMap();
                    //Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Health_P);

                    Console.WriteLine("общее количество шагов: " + steps);
                    if (buffstep < 5)
                    {
                        Console.WriteLine("Осталось " + (5 - buffstep) + " шагов до конца баффа");
                    }
                }

                if (kol <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Игра окончена за " + steps + " шагов. Вы выиграли");
                    break;
                }
                //    }

                //    break;
                //}

            }

        }

        static void GenerateMap()
        {
            Random rnd = new();
            //map[playerX, playerY] = "X";
            for (int i = 0; i < 6; i++)
            {
                int height = rnd.Next(0, 25);
                int width = rnd.Next(0, 25);
                if (map[height, width] == ".")
                {
                    map[height, width] = enemy;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                int height = rnd.Next(0, 25);
                int width = rnd.Next(0, 25);
                if (map[height, width] == ".")
                {
                    map[height, width] = aid;
                }
            }//спавн аптечки
            for (int i = 0; i < 3; i++)
            {
                int height = rnd.Next(0, 25);
                int width = rnd.Next(0, 25);
                if (map[height, width] == ".")
                {
                    map[height, width] = buff;
                }
            }//спавн бафа
            ///*   string[,] map = new string[25, 25];/*//размер поля
            //   //var rand1 = new Random();
            //   //int value1 = rand1.Next(25);
            //   int g = 0;
            //   while (g != 6) // спавн врагов 
            //   {
            //       int xx = rand1.Next(0, 25);
            //       int yy = rand1.Next(0, 25);
            //       if (map[xx, yy] == ".")
            //           map[xx, yy] = enemy;
            //       g++;
            //   }
            //   int c = 0;
            //   while (c != 3) // спавн аптечек
            //   {
            //       int xx = rand1.Next(0, 25);
            //       int yy = rand1.Next(0, 25);
            //       if (map[xx, yy] == ".")
            //           map[xx, yy] = aid;
            //       c++;
            //   }
            //   int x = 0;
            //   while (x != 2) // спавн бустов
            //   {
            //       int xx = rand1.Next(0, 25);
            //       int yy = rand1.Next(0, 25);
            //       if (map[xx, yy] == ".")
            //           map[xx, yy] = buff;
            //       x++;
            //   }
            //   //int playerX = 12;
            //   //int playerY = 12;
              
            //string playerChar = "X";
            //Console.Write(playerChar);
            //// Анимация движения игрока
            //playerChar = playerChar == "X" ? "Y" : "X";
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == enemy)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (map[i, j] == aid)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (map[i, j] == buff)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    //if (map[i, j] == playerChar)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Yellow;
                    //}
                    //if (map[i, j] == "W")
                    //{
                    //    Console.ForegroundColor = ConsoleColor.White;
                    //}

                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
            //    return map;
        }
        static void UpdateMap()
        {
            map[12, 12] = hero;
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (map[i, j] == enemy)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if (map[i, j] == aid)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (map[i, j] == buff)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                    }
                    if (map[i, j] == hero)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    //if (map[i, j] == ".")
                    //{
                    //    Console.ForegroundColor = ConsoleColor.White;
                    //}

                    Console.Write(map[i, j] + " ");

                }
                Console.Write("");
            }
            //return (map);
        }

        static void Direction()
        {

            steps = steps += 1;
            buffstep = buffstep += 1;
            if (buffstep >= 5)
            {
                hero_dmg = 5;
            }

            Console.CursorVisible = false; // гасим курсор
            ConsoleKeyInfo k;
            string playerChar = "X";
            Console.Write(playerChar);
            // Анимация движения игрока
            playerChar = playerChar == "X" ? "Y" : "X";

            //Координаты игрока

            //int playerX = 12;
            //int playerY = 12;

            //char playerChar = 'X';

            do
            {

                Console.SetCursorPosition(playerX, playerY);
                //Console.Write(playerChar);
                //// Анимация движения игрока
                //playerChar = playerChar == 'X' ? 'Y' : 'X';

                k = Console.ReadKey(true);


                if (k.Key
                    == ConsoleKey.UpArrow)
                {
                    playerY--;
                    if (playerX < 0) playerX = 24;
                }
                else if (k.Key
                    == ConsoleKey.DownArrow)
                {
                    playerY++;
                    if (playerX > 24) playerX = 0;
                }
                else if (k.Key 
                    == ConsoleKey.LeftArrow)
                {

                    playerX--;
                    if (playerY < 0) playerY = 24;
                }
                else if (k.Key 
                    == ConsoleKey.RightArrow)
                {
                    playerX++;
                    if (playerY > 24) playerY = 0;
                }


                //else if (k.Key == ConsoleKey.S) // сохранение игры по кнопке
                //{
                //    string[] linesForTxt = new string[map.GetLength(0) + 1];
                //    int[] product = Enumerable.Repeat(1, map.GetLength(1)).ToArray();

                //    for (int i = 0; i < map.GetLength(0); i++)
                //    {
                //        int sum = 0;


                //        for (int j = 0; j < map.GetLength(1); j++)
                //        {

                //            sum += map[i, j];


                //            linesForTxt[i] += map[i, j] + " ";


                //            product[j] += map[i, j];
                //        }
                //        linesForTxt[i] += sum;
                //        linesForTxt[linesForTxt.Length - 1] = string.Join(" ", product) + " X";


                //        File.WriteAllText(@"D:\result.txt", string.Join("\n", linesForTxt));
                //        Console.Clear();
                //        Console.WriteLine("Игра сохранена");
                //    }

                {


                    break; // выходим из цикла do - while

                }

            }
            while (k.Key != ConsoleKey.Escape); // выходим из цикла по нажатию Esc
            {
                Console.CursorVisible = true;
            }
            //return map;
        }

        static void Fight()
        {
            Health_F = 15;
            for (int i = 0; Health_P != 0 & Health_F != 0; i++)
            {
                Health_F = Health_F - hero_dmg;
                if (Health_F <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    //Console.WriteLine("Враг убит!");
                    Console.ReadKey();
                    break;
                }
                Health_P = Health_P - enemy_dmg;
                if (Health_P == 0 | Health_P < 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы убиты.......");
                    Console.ReadKey();
                }

            }
            kol = kol--;
            //return (map);
        }
        static void Healing()
        {
            Health_P = 30;
        }
        static void Buff()
        {
            buffstep = 0;
            hero_dmg = 10;
        }
    }
}