using System;

class URI
{

    static void Main(string[] args)
    {

        string[] input = Console.ReadLine().Split();

        double n1 = double.Parse(input[0]);
        double n2 = double.Parse(input[1]);
        double n3 = double.Parse(input[2]);
        double n4 = double.Parse(input[3]);

        double media = Math.Floor(n1 * 2.0 + n2 * 3.0 + n3 * 4.0 + n4 * 1.0) / 10.0;
        Console.WriteLine($"Media: {media:F1}");

        if (media >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        } else
        {
            Console.WriteLine("Aluno em exame.");

            double examNote = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nota do exame: {examNote:F1}");

            double finalMedia = (media + examNote) / 2;

            if (finalMedia >= 5.0)
            {
                Console.WriteLine("Aluno aprovado.");
            } else
            {
                Console.WriteLine("Aluno reprovado.");
            }

            Console.WriteLine($"Media final: {finalMedia:F1}");
        }
    }

}