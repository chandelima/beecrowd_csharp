using System;

class URI
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int x;
        int y;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            string[] rawString = Console.ReadLine().Split(' ');
            x = int.Parse(rawString[0]);
            y = int.Parse(rawString[1]);

            if (y > x)
            {
                int aux = x;
                x = y;
                y = aux;
            }

            for (int z = y + 1; z < x; z++)
            {
                if (z % 2 == 1)
                    sum += z;
            }

            Console.WriteLine(sum);
            sum = 0;
        }

    }

}