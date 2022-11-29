using System; 

class URI {

    static void Main(string[] args) { 

        string[] rawConsole = Console.ReadLine().Split(' ');

        int h1 = int.Parse(rawConsole[0]);
        int m1 = int.Parse(rawConsole[1]);
        int h2 = int.Parse(rawConsole[2]);
        int m2 = int.Parse(rawConsole[3]);

        int totalM1 = (h1 * 60) + m1;
        int totalM2 = (h2 * 60) + m2;

        if (totalM2 <= totalM1)
            totalM2 += 1440;

        int total = totalM2 - totalM1;
        
        int totalHours = total / 60;
        int totalMinutes = total % 60;

        Console.WriteLine($"O JOGO DUROU {totalHours} HORA(S) E {totalMinutes} MINUTO(S)");
        

    }

}