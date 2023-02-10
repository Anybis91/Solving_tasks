using System;
using System.Linq;
using System.Text;
using System.IO;

namespace BraveNewWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            Console.CursorVisible = false;
            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#', },
                {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', },
                {'#',' ','#',' ','#','#','#','#','#','#',' ','#',' ','#', },
                {'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ','#', },
                {'#','#','#','#','#',' ','#','#','#','#','#','#',' ','#', },
                {'#',' ',' ',' ',' ',' ','#','#','#','#','O','#',' ','#', },
                {'#',' ','#','#','#','#','#','#','#','#',' ','#',' ','#', },
                {'#',' ','#','O',' ','#',' ',' ',' ','#',' ','#',' ','#', },
                {'#',' ','#','#',' ','#',' ','#',' ','#',' ','#',' ','#', },
                {'#',' ',' ',' ',' ','#',' ','#',' ','#',' ',' ',' ','#', },
                {'#','#','#','#',' ','#',' ','#','O','#','#','#',' ','#', },
                {'#','#','#','#',' ','#',' ','#','#','#','#','#',' ','#', },
                {'#','O',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#', },
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#', },
            };
            int userX = 1, userY = 1;
            char[] bag = new char[1];

            while (isWork)
            {
                Console.SetCursorPosition(0, 15);
                Console.Write("Сумка: ");

                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + "  ");
                }

                DrawMap(ref map);

                Console.SetCursorPosition(userY, userX);
                Console.Write('&');
                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                }

                if (map[userX, userY] == 'O')
                {
                    map[userX, userY] = ' ';
                    char[] tempBag = new char[bag.Length + 1];

                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }

                    tempBag[tempBag.Length - 1] = 'O';
                    bag = tempBag;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawMap(ref char[,] map)
        {
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}