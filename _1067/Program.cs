using System; 

class URI {

    static void Main(string[] args) { 

        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i <= input; i++)
        {
            if(i%2 == 1)
                System.Console.WriteLine(i);
        }
    }

}