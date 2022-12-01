using System; 

class URI {

    static void Main(string[] args) { 

        int maxValue = 0;
        int maxIndex = 0;

        for (int i = 1; i <= 100; i++)
        {
            int value = int.Parse(Console.ReadLine());

            if(value > maxValue) {
                maxValue = value;
                maxIndex = i;
            }
        }

        Console.WriteLine(maxValue);
        Console.WriteLine(maxIndex);

    }

}