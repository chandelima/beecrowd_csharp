using System;

class URI
{

    static void Main(string[] args)
    {

        string consoleRaw = Console.ReadLine();
        string[] arrayData = consoleRaw.Split();

        int a = int.Parse(arrayData[0]);
        int b = int.Parse(arrayData[1]);
        int c = int.Parse(arrayData[2]);
        int d = int.Parse(arrayData[3]);

        if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0)
            Console.WriteLine("Valores aceitos");
        else
            Console.WriteLine("Valores nao aceitos");
    }

}