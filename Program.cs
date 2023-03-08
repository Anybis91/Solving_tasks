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
            List<string> list = new List<string>();
            AddInList(list, firstArray);
            AddInList(list, secondArray);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        static void AddInList(List<string> list, string[] firstArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (list.Contains(firstArray[i]) == false)
                {
                    list.Add(firstArray[i]);
                }
            }
        }
    }
}