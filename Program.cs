using System;

namespace Task_Kansas_city_shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[11] {1,2,3,4,5,6,8,9,3,5,7};
            Console.WriteLine("Массив с данными:");
            OutputArray(ref myArray);
            Shuffle(ref myArray);
            Console.WriteLine("\nПеремешанный массив:");
            OutputArray(ref myArray);
        }

        static void Shuffle(ref int[] myArray)
        {
            Random randomNumberInArray = new Random();
            int tempIndex;
            int tempNumber;

            for (int i = myArray.Length-1; i >=1; i--)
            {
                tempIndex = randomNumberInArray.Next(i+1);
                tempNumber = myArray[tempIndex];
                myArray[tempIndex] = myArray[i];
                myArray[i]=tempNumber;
            }
        }

        static void OutputArray(ref int[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
        }
    }
}