using System;

namespace Task_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbes= new int[10] {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("Ваш массив: ");
            int userInput;
            
            for(int i=0;i<arrayNumbes.Length;i++)
            {
                Console.Write(arrayNumbes[i]+ " ");
            }

            Console.WriteLine("\nВведите число для сдвига массива: ");
            userInput=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<userInput;i++)
            {
                int variableNumber = arrayNumbes[arrayNumbes.Length - 1];

                for (int j = arrayNumbes.Length - 1; j > 0; j--)
                {
                    arrayNumbes[j] = arrayNumbes[j - 1];
                }

                arrayNumbes[0] = variableNumber;
            }

            Console.WriteLine("Результат: ");
            
            for (int i = 0; i < arrayNumbes.Length; i++)
            {
                Console.Write(arrayNumbes[i] + " ");
            }
        }
    }
}