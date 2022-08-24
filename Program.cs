using System;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberRandom=random.Next(0,1000);
            int numberDegree = 1;
            int degree = 2;
            bool isWork = true;
            int numberIterationDegree = 0;

            while(isWork)
            {
                if (numberDegree < numberRandom)
                {
                    numberDegree = numberDegree * degree;
                    numberIterationDegree++;
                }
                else
                {
                    Console.WriteLine("Расчет выполнен!");
                    isWork = false;
                    Console.WriteLine("Число рандома = "+ numberRandom);
                    Console.WriteLine("Степень "+ numberIterationDegree);
                    Console.WriteLine("Само число 2 в найденной степени "+numberDegree);
                }
            }

        }
    }
}