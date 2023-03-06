using System;
using System.Collections.Generic;

namespace Task_Merging_into_one_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = new string[] { "22", "2", "5", "9", "6" };
            string[] secondArray = new string[] { "10", "7", "3", "5", "1", "2" };
            int tempnumber=0;
            List<int> list = new List<int>();

            int[] firstIntArray = new int[firstArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstIntArray[i] = Convert.ToInt32(firstArray[i]);
            }

            int[] secondIntArray = new int[secondArray.Length];

            for (int i = 0; i < secondArray.Length; i++)
            {
                secondIntArray[i] = Convert.ToInt32(secondArray[i]);
            }

            AddInList(list, firstArray.Length, firstIntArray);
            AddInList(list, secondArray.Length, secondIntArray);

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        tempnumber = list[i];
                        list[i] = list[j];
                        list[j] = tempnumber;
                    }
                }

                Console.Write(list[i] + " ");
            }
        }

        static void AddInList(List<int> list, int arrayLength, int[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                if (list.Contains(array[i]) == false)
                {
                    list.Add(array[i]);
                }
            }
        }
    }
}