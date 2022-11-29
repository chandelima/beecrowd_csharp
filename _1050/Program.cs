using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {
        Dictionary<int, string> ddds = new Dictionary<int, string>()
        {
            {61, "Brasilia"},
            {71, "Salvador"},
            {11, "Sao Paulo"},
            {21, "Rio de Janeiro"},
            {32, "Juiz de Fora"},
            {19, "Campinas"},
            {27, "Vitoria"},
            {31, "Belo Horizonte"},
        };

        string input = Console.ReadLine();
        int ddd = int.Parse(input);

        if (ddds.ContainsKey(ddd))
        {
            string result;
            ddds.TryGetValue(ddd, out result);
            Console.WriteLine(result);
        } else
        {
            Console.WriteLine("DDD nao cadastrado");
        }
    }
}