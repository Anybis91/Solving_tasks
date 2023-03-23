using System;

namespace Task_Working_with_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rendered renderedPlayer= new Rendered();
            Player Anybis = new Player(10, 7);

            renderedPlayer.DrawPlayer(Anybis.X,Anybis.Y);
        }
    }

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
     
    class Rendered
    {
        public void DrawPlayer(int x,int y,char playerIcon='@')
        {
            Console.SetCursorPosition(x, y);
            Console.Write(playerIcon);
        }
    }
}