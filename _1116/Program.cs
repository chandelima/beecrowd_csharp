using System; 

class URI {

    static void Main(string[] args) { 

        int repeatAmount = int.Parse(Console.ReadLine());
        float n1, n2, result;

        for (int i = 0; i < repeatAmount; i++)
        {
            string[] inputData = Console.ReadLine().Split(' ');
            n1 = int.Parse(inputData[0]);
            n2 = int.Parse(inputData[1]);

            if (n2 != 0)
            {
               result = n1 / n2;
                System.Console.WriteLine($"{result:F1}");
            } else {
                System.Console.WriteLine("divisao impossivel");
            }            
        }
    }

}