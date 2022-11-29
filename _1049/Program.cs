using System;

class URI
{

    static void Main(string[] args)
    {

        string input = Console.ReadLine();
        double income = double.Parse(input);
        double tax;

        if(income <= 2000.00)
        {
            tax = 0.00;
        }
        else if (income <= 3000.00)
        {
            tax = (income - 2000.00) * 0.08;
        }
        else if (income <= 4500.0)
        {
            tax = (income - 3000.00) * 0.18
                + 1000 * 0.08;
        }
        else
        {
            tax = (income - 4500.00) * 0.28
                + 1500 * 0.18
                + 1000 * 0.08;
        }

        if(tax == 0)
            Console.WriteLine("Isento");
        else
            Console.WriteLine($"R$ {tax:F2}");

    }

}