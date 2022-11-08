using System;

namespace Task_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = "Съешь же ещё этих мягких французских булок, да выпей чаю!";
            string[] subs = myText.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"{sub}");
            }
        }
    }
}