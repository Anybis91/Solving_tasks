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
            int userDirectionX=0, userDirectionY=1 ;
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
                ConsoleKeyInfo pressKey = Console.ReadKey();
                
                switch (pressKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        userDirectionX = -1; userDirectionY = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        userDirectionX = 1; userDirectionY = 0;
                        break;
                    case ConsoleKey.LeftArrow:
                        userDirectionX = 0; userDirectionY = -1;
                        break;
                    case ConsoleKey.RightArrow:
                        userDirectionX = 0; userDirectionY = 1;
                        break;
                }

                Console.SetCursorPosition(userY, userX);
                Console.Write(' ');

                if (map[userX + userDirectionX, userY + userDirectionY] != '#')
                {
                    userX += userDirectionX;
                    userY += userDirectionY;
                    Console.SetCursorPosition(userY, userX);
                    Console.Write("&");
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