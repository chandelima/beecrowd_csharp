using System;

class URI
{

    static void Main(string[] args)
    {
        string[] consoleRaw = Console.ReadLine().Split();

        float a = float.Parse(consoleRaw[0]);
        float b = float.Parse(consoleRaw[1]);
        float c = float.Parse(consoleRaw[2]);

        if (isTriangle(a, b, c))
        {
            float perimeter = a + b + c;
            Console.WriteLine($"Perimetro = {perimeter:F1}");
        } else
        {
            float area = ((a + b) * c) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }

    }

    static bool isTriangle(float n1, float n2, float n3)
    {
        bool cond1 = n1 < (n2 + n3);
        bool cond2 = n2 < (n1 + n3);
        bool cond3 = n3 < (n1 + n2);
        
        bool result;
        if (cond1 && cond2 && cond3)
        {
            result = true;
        } else
        {
            result = false;
        }

        return result;
    }

}