using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayHelper<int> arrayHelper = new ArrayHelper<int>();

            bool success;

            int[] intArray = { 1, 642, 135, 6583, 2, 64, 2, 67 };
            int intElement;

            string[] stringArray = { "agad", "24yedqawg", "g53q", "35yg" };
            string stringElement;

            int[] subArray = arrayHelper.ReturnSubArray(intArray, 6, 2);

            Console.WriteLine($"ReturnIndex: {arrayHelper.ReturnIndexOfElement(intArray, 6583)}");
            Console.WriteLine($"ReturnIndex: {arrayHelper.ReturnIndexOfElement(intArray, 333333)}");

            success = arrayHelper.SearchResult<int>(intArray, 8, out intElement);
            Console.WriteLine($"SearchResult: {success}, {intElement}");

            success = arrayHelper.SearchResult<string>(stringArray, 0, out stringElement);
            Console.WriteLine($"SearchResult: {success}, {stringElement}");

            Console.Write("SubArray: ");
            if (subArray is null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                for (int i = 0; i < subArray.Length; i++)
                {
                    Console.Write($"{subArray[i]}, ");
                }
                Console.WriteLine();
            }

            int[] sortedArray = arrayHelper.ArraySort<int>(intArray);

            Console.Write("Sorted Array: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write($"{sortedArray[i]}, ");
            }
            Console.WriteLine();

        }
    }
}
