using System; 
using System.Text;

class URI {

    static void Main(string[] args) { 

        int amount = int.Parse(Console.ReadLine());

        for (int i = 0; i < amount; i++)
        {
            int value = int.Parse(Console.ReadLine());

            if(value == 0)
                Console.WriteLine("NULL");
            else if(value > 0){
                if(value%2 == 0)
                    Console.WriteLine("EVEN POSITIVE");
                else
                    Console.WriteLine("ODD POSITIVE");
            } else {
                if(value%2 == 0)
                    Console.WriteLine("EVEN NEGATIVE");
                else
                    Console.WriteLine("ODD NEGATIVE");
            }
        }
    }

}