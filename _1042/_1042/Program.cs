using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        string[] rawConsole = Console.ReadLine().Split();

        int[] inputArray = new int[]
        {
            int.Parse(rawConsole[0]),
            int.Parse(rawConsole[1]),
            int.Parse(rawConsole[2])
        };

        int[] sortedArray = new int[3];
        Array.Copy(inputArray, sortedArray, inputArray.Length);
        Array.Sort(sortedArray);

        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.WriteLine(sortedArray[i]);
        }

        Console.WriteLine();

        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.WriteLine(inputArray[i]);
        }
    }

}