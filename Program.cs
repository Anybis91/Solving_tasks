using System;
using System.Xml.Linq;

namespace Task_Working_with_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Anybis = new Player("Артус", 150, 300, 20, 35);
            Anybis.ShowInfo();
            Console.ReadKey();
        }
    }

    class Player
    {
        private string _name;
        private int _mana;
        private int _health;
        private int _armor;
        private int _damage;

        public Player(string name, int mana, int health, int armor, int damage)
        {
            _name = name;
            _mana = mana;
            _health = health;
            _armor = armor;
            _damage = damage;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Имя игрока - " + _name + "\nЗдоровье - " + _health + "\nМана - " + _mana + "\nБроня - " + _armor + "\nУрон - " + _armor);
        }
    }
}
