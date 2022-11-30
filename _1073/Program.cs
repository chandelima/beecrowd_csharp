using System; 

class URI {

    static void Main(string[] args) { 

        int value = int.Parse(Console.ReadLine());

        for (int i = 1; i <= value; i++)
        {
            if(i%2 == 0)
                System.Console.WriteLine($"{i}^2 = {i*i}");
        }
    }

}