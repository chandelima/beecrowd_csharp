using System;

class URI
{

    static void Main(string[] args)
    {

        string[] inputs = Console.ReadLine().Split();
        
        int code = int.Parse(inputs[0]);
        int amount = int.Parse(inputs[1]);
        decimal price = 0;

        switch (code)
        {
            case 1:
                price = 4.00M;
                break;
            case 2:
                price = 4.50M;
                break;
            case 3:
                price = 5.00M;
                break;
            case 4:
                price = 2.00M;
                break;
            case 5:
                price = 1.50M;
                break;
        }

        decimal total = amount * price;
        Console.WriteLine($"Total: R$ {total:F2}");

    }

}