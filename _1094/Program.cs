using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        float totalRabbits = 0;
        float totalMice = 0;
        float totalFrogs = 0;

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            float amount = float.Parse(input[0]);
            char type = char.Parse(input[1]);

            switch(type) {
                case 'C':
                    totalRabbits += amount;
                    break;
                case 'R':
                    totalMice += amount;
                    break;
                case 'S':
                    totalFrogs += amount;
                    break;
            }
        }

            float total = totalFrogs + totalMice + totalRabbits;
            
            float percentualRabbits = totalRabbits / total * 100.00f;
            float percentualMice = totalMice / total * 100.00f;
            float percentualFrogs = totalFrogs / total * 100.00f;

            System.Console.WriteLine($"Total: {total:F0} cobaias");
            System.Console.WriteLine($"Total de coelhos: {totalRabbits:F0}");
            System.Console.WriteLine($"Total de ratos: {totalMice:F0}");
            System.Console.WriteLine($"Total de sapos: {totalFrogs:F0}");
            System.Console.WriteLine($"Percentual de coelhos: {percentualRabbits:F2} %");
            System.Console.WriteLine($"Percentual de ratos: {percentualMice:F2} %");
            System.Console.WriteLine($"Percentual de sapos: {percentualFrogs:F2} %");
    }

}