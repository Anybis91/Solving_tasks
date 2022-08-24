using System;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMinRange = 0;
            int numberMaxRange = 1000;
            Random random = new Random();
            int numberRandom=random.Next(numberMinRange, numberMaxRange);
            int degree = 2;
            int startNumberDegree = 2;
            bool isWork = true;
            int numberIterationDegree = 1;

            while(isWork)
            {
                if (startNumberDegree < numberRandom)
                {
                    startNumberDegree = startNumberDegree*degree;
                    numberIterationDegree++;
                }
                else
                {
                    Console.WriteLine("Расчет выполнен!");
                    isWork = false;
                    Console.WriteLine("Число рандома = "+ numberRandom);
                    Console.WriteLine("Степень "+ numberIterationDegree);
                    Console.WriteLine("Само число "+ degree + " в найденной степени "+ startNumberDegree);
                }
            }

        }
    }
}