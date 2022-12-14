using System; 

class URI {

    static void Main(string[] args) { 

        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int sum = 0;

        orderInts(ref n1, ref n2);

        for (int i = n1; i <= n2; i++)
        {
            if(i % 13 != 0)
                sum += i;
        }

        System.Console.WriteLine(sum);
    }

    static void orderInts(ref int x1, ref int x2) {
        if (x1 > x2) {
            int aux = x1;
            x1 = x2;
            x2 = aux;
        }
    }

}