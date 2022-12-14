using System; 
using System.Linq;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) { 

        int newRound = 1, inter, gremio;
        string[] inputData;
        Grenal round;
        List<Grenal> results = new List<Grenal>();

        while (newRound != 2)
        {
            inputData = Console.ReadLine().Split(' ');
            inter = int.Parse(inputData[0]);
            gremio = int.Parse(inputData[1]);

            round = new Grenal(inter, gremio);
            results.Add(round);

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            newRound = int.Parse(Console.ReadLine());
        }
        // Total grenais
        int toalGrenais = results.Count();
        Console.WriteLine($"{toalGrenais} grenais");
        // Inter wins
        int interWins = results.Where(r => r.Inter > r.Gremio).Count();
        Console.WriteLine($"Inter:{interWins}");

        // Gremio wins
        int gremioWins = results.Where(r => r.Gremio > r.Inter).Count();
        Console.WriteLine($"Gremio:{gremioWins}");

        // Goalless
        int goallessRounds = results.Where(r => r.Gremio == r.Inter).Count();
        Console.WriteLine($"Empates:{goallessRounds}");

        // Who wins more
        if(interWins > gremioWins)
            Console.WriteLine("Inter venceu mais");
        else if(gremioWins > interWins)
            Console.WriteLine("Gremio venceu mais");
    }

}

class Grenal {

    public int Inter { get; }
    public int Gremio { get; }

    public Grenal(int inter, int gremio)
    {
        Inter = inter;
        Gremio = gremio;
    }
}