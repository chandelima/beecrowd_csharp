using System; 

class URI {

    public static void Main(string[] args) {
        
        int i = 1;
        int j = 7;

        while (i <= 9 || j <= 13)
        {
            for (int x = 3; x >= 1; x--)
            {
                Console.WriteLine($"I={i} J={j}");
                j--;
            }

            i+=2;
            j+=5;
        }
    }
}