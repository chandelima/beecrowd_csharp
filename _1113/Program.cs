using System; 

class URI {

    static void Main(string[] args) { 

        string[] rawInput;
        int n1, n2;

        do
        {
            rawInput = Console.ReadLine().Split(' ');
            n1 = int.Parse(rawInput[0]);
            n2 = int.Parse(rawInput[1]);

            if(n2 > n1 && n1 != n2)
                Console.WriteLine("Crescente");
            else if(n1 != n2)
                Console.WriteLine("Decrescente");

        } while (n1 != n2);
    }

}