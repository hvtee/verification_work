using System;

namespace project
{
    class Program
    {
        static string[] CreateArray(int arrSize)
        {
            string[] arr = new string[arrSize];
            for (int i = 0; i < arrSize; i++)
                arr[i] = Convert.ToString(new Random().Next(-1000, 1000 + 1));
            return arr;
        }
        static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                System.Console.Write(arr[i] + " ");
            
            System.Console.WriteLine(" ");
        }
        static int FindSizeToSortArray(string[] arr)
        {
            int newSize = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= 3) newSize++;
            }
            return newSize;
        }
        static void SortArray(string[] arr, string[] newArr)
        {
            for (int i = 0, j = 0; i < arr.Length; i++)
                if (arr[i].Length <= 3)
                {
                    newArr[j] = arr[i]; j++;
                }
        }
        static void Main()
        {
            Console.Clear();

            System.Console.WriteLine("Input array size: ");
            int arraySize = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("1:Input manually, 2:Input automatically");
            int wayToCreateArray = int.Parse(Console.ReadLine()!);

            string[] array = new string[arraySize];
            if (wayToCreateArray == 1)
                for (int i = 0; i < arraySize; i++)
                     array[i] = Console.ReadLine()!;
            else if (wayToCreateArray == 2)
                 array = CreateArray(arraySize);
            else System.Console.WriteLine("Wrong choice");

            PrintArray(array);

            string[] newArray = new string[FindSizeToSortArray(array)];
            SortArray(array, newArray);
            PrintArray(newArray);
        }
    }
}