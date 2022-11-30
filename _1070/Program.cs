using System; 

class URI {

    static void Main(string[] args) { 

        int input = int.Parse(Console.ReadLine());
        int count = 0;

        while (count < 6){
            if(input %2 == 1) {
                Console.WriteLine(input);
                count++;
            }
            input++;
        }
    }

}