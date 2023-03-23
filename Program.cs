using System;

namespace Task_Working_with_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rendered renderedPlayer= new Rendered();
            Player Anybis = new Player(10, 7,'$');

            renderedPlayer.DrawPlayer(Anybis.X, Anybis.Y,Anybis.PlayerIcon);
        }
    }

    class Player
    {
        public int X;
        public int Y;
        public char PlayerIcon;

        public Player(int x, int y,char playerIcon)
        {
            X = x;
            Y = y;
            PlayerIcon = playerIcon;
        }
    }
     
    class Rendered
    {
        public void DrawPlayer(int x,int y,char playerIcon)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerIcon);
        }
    }
}