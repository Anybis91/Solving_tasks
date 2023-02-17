using System;

namespace Task_Kansas_city_shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {1,2,3,4,5,6,8,9,3,5,7};
            Console.WriteLine("Массив с данными:");
            OutputArray(numbers);
            Shuffle( numbers);
            Console.WriteLine("\nПеремешанный массив:");
            OutputArray(numbers);
        }

        static void Shuffle(int[] numbers)
        {
            Random randomNumberInArray = new Random();
            int tempIndex;
            int tempNumber;

            for (int i = numbers.Length-1; i >=1; i--)
            {
                tempIndex = randomNumberInArray.Next(i+1);
                tempNumber = numbers[tempIndex];
                numbers[tempIndex] = numbers[i];
                numbers[i]=tempNumber;
            }
        }

        static void OutputArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}