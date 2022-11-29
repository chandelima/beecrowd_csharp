using System;

class URI
{

    static void Main(string[] args)
    {

        string consoleRaw = Console.ReadLine();
        string[] arrayData = consoleRaw.Split();

        double a = double.Parse(arrayData[0]);
        double b = double.Parse(arrayData[1]);
        double c = double.Parse(arrayData[2]);

        double delta = Math.Pow(b, 2) - (4 * a * c);
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        if (delta > 0 && a != 0)
        {
            Console.WriteLine($"R1 = {x1:F5}");
            Console.WriteLine($"R2 = {x2:F5}");
        }
        else
        {
            Console.WriteLine("Impossivel calcular");
        }
    }

}