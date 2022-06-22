using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numImageUser = 52;
            int numImageRow = 3;
            int totalNumRow = numImageUser / numImageRow;
            int remainImageNum = numImageUser % numImageRow;
            Console.WriteLine($"У пользователя {numImageUser} картинок. В ряду может находиться только {numImageRow} картинки. ");
            Console.WriteLine($"Всего будет выведено {totalNumRow} рядов, и тогда останется {remainImageNum} картинка не использованная в рядах.");
            Console.WriteLine($"Иначе можно вывести {totalNumRow+1} рядов, и тогда в последнем ряду будет {remainImageNum} картинка.");
            Console.ReadKey();
        }
    }
}
