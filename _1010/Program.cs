using System;

class URI
{

    static void Main(string[] args)
    {

        string consoleRawP1 = Console.ReadLine();
        string[] arrayDataP1 = consoleRawP1.Split();

        int p1Amount = int.Parse(arrayDataP1[1]);
        decimal p1Price = decimal.Parse(arrayDataP1[2]);
        decimal p1TotalPrice = p1Amount * p1Price;

        string consoleRawP2 = Console.ReadLine();
        string[] arrayDataP2 = consoleRawP2.Split();

        int p2Amount = int.Parse(arrayDataP2[1]);
        decimal p2Price = decimal.Parse(arrayDataP2[2]);
        decimal p2TotalPrice = p2Amount * p2Price;

        decimal sellTotalPrice = p1TotalPrice + p2TotalPrice;

        Console.WriteLine($"VALOR A PAGAR: R$ {sellTotalPrice:F2}");
    }

}