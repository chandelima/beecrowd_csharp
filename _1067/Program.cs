using System; 

class URI {

    static void Main(string[] args) { 

        int input = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i <= input; i++)
        {
            if(i%2 == 1)
                System.Console.WriteLine(i);
        }
    }

}