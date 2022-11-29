using System; 

class URI {

    static void Main(string[] args) { 

        string[] rawConsole = Console.ReadLine().Split(' ');

        int n1 = int.Parse(rawConsole[0]);
        int n2 = int.Parse(rawConsole[1]);

        if(n1 < n2) {
            int aux = n1;
            n1 = n2;
            n2 = aux;
        }

        if(n1 % n2 == 0) {
            System.Console.WriteLine("Sao Multiplos");
        } else {
            System.Console.WriteLine("Nao sao Multiplos");
        }
    }

}