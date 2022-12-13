using System; 

class URI {

    static void Main(string[] args) { 

        decimal i = 0;
        decimal j = 1;

        while(i <= 2)
        {
            for (int z = 0; z < 3; z++)
            {
                if(i.ToString().EndsWith("0"))
                    Console.WriteLine($"I={i:F0} J={j:F0}");
                else
                    Console.WriteLine($"I={i} J={j}");
                j++;
            }

            i+=0.2m;
            j+=0.2m;
            j-=3;
        }
    }

}