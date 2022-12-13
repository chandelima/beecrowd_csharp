using System; 

class URI {

    static void Main(string[] args) {

        string[] rawInput;
        int n1, n2;
        int sum = 0;
        bool condition;

        do
        {
            rawInput = Console.ReadLine().Split(' ');
            n1 = int.Parse(rawInput[0]);
            n2 = int.Parse(rawInput[1]);
            condition = n1 > 0 && n2 > 0;

            orderInts(ref n1, ref n2);

            if(condition)
            {
                for (int i = n1; i <= n2; i++)
                {
                    sum += i;
                    Console.Write($"{i} ");
                }
                Console.WriteLine($"Sum={sum}");
            }
            sum = 0;
        } while (condition);
    }

    static void orderInts(ref int x1, ref int x2) {
        if (x1 > x2) {
            int aux = x1;
            x1 = x2;
            x2 = aux;
        }
    }

}