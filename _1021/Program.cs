using System;

class URI
{

    static void Main(string[] args)
    {

        decimal value = decimal.Parse(Console.ReadLine());
        decimal totalRest = value;

        int[] bankNotes = new int[]{
            100, 50, 20, 10, 5, 2
        };
        decimal[] bankCoins = new decimal[]{
           1.00M, 0.50M, 0.25M, 0.10M, 0.05M, 0.01M
        };

        Console.WriteLine("NOTAS:");
        foreach (int bankNote in bankNotes)
        {
            totalRest = ProccessNotes(totalRest, bankNote);
        }

        Console.WriteLine("MOEDAS:");
        foreach (decimal bankCoin in bankCoins)
        {
            totalRest = ProccessCoins(totalRest, bankCoin);
        }
    }

    static decimal ProccessNotes(decimal decrease, decimal bankNote)
    {
        int amount = (int)(decrease / bankNote);

        Console.WriteLine($"{amount} nota(s) de R$ {bankNote:F2}");

        decimal rest = decrease - (amount * bankNote);
        return rest;
    }

    static decimal ProccessCoins(decimal decrease, decimal bankCoin)
    {
        int amount = (int)(decrease / bankCoin);

        Console.WriteLine($"{amount} moeda(s) de R$ {bankCoin:F2}");

        decimal rest = decrease - (amount * bankCoin);
        return rest;
    }

}