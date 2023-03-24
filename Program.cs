﻿using System;

namespace Task_Working_with_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rendered renderedPlayer= new Rendered();
            Player Anybis = new Player(10, 7);

            renderedPlayer.DrawPlayer(Anybis.positionX,Anybis.positionY);
        }
    }

    class Player
    {
        public int positionX { get; private set; }
        public int positionY { get; private set; }

        public Player(int x, int y)
        {
            positionX = x;
            positionY = y;
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