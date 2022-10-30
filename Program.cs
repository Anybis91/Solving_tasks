using System;

namespace Task_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbes = new int[20];
            Random rand = new Random();
            int minValue = 0;
            int maxValue = 100;
            int varNumber = 0;
            Console.WriteLine("\nНачальный массив: ");

            for (int i = 0; i < arrayNumbes.Length; i++)
            {
                arrayNumbes[i] = rand.Next(minValue, maxValue);
                Console.Write(arrayNumbes[i] + " ");
            }

            Console.WriteLine("\nЧисла по порядку: ");

            for (int i =0; i < arrayNumbes.Length; i++)
            {
                for(int j=i+1;j< arrayNumbes.Length; j++)
                {
                    if (arrayNumbes[i] > arrayNumbes[j])
                    {
                        varNumber = arrayNumbes[i];
                        arrayNumbes[i]= arrayNumbes[j];
                        arrayNumbes[j]=varNumber;
                    }
                }

                Console.Write(arrayNumbes[i] + " ");
            }
        }
    }
}