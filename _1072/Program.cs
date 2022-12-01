using System; 

class URI {

    static void Main(string[] args) { 

        int amount = int.Parse(Console.ReadLine());
        int inCount = 0;
        int outCount = 0;

        for (int i = 0; i < amount; i++)
        {
            int temp = int.Parse(Console.ReadLine());

            if(temp >= 10 && temp <= 20)
                inCount++;
            else
                outCount++;
        }

        Console.WriteLine($"{inCount} in");
        Console.WriteLine($"{outCount} out");
    }

    static void calcMedia(float n1, float n2, float n3) {
        float media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
        Console.WriteLine($"{media:F1}");
    }

}