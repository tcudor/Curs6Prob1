using System.Drawing;

namespace Curs6Prob1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ConsoleHelper.ReadNumber("The size of the array = ", 3, 0);
            int[] array = new int[size];

            for (int i = 0; i < array.Length; i++)
            {
                int element = ConsoleHelper.ReadNumber($"element[{i}] = ", 3, 0);
                array[i] = element;
            }
            ConsoleHelper.PrintArray("Array=", array);

            int minR = ArrayHelper.MinR(array, 0, size-1);
            Console.WriteLine($"Min = {minR}");

            int maxR = ArrayHelper.MaxR(array, 0, size-1);
            Console.WriteLine($"Max = {maxR}");
        }
    }       
}