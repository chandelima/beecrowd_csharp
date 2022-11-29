using System; 

class URI {

    static void Main(string[] args) { 

        float[] inputs = new float[5];

        inputs[0] = float.Parse(Console.ReadLine());
        inputs[1] = float.Parse(Console.ReadLine());
        inputs[2] = float.Parse(Console.ReadLine());
        inputs[3] = float.Parse(Console.ReadLine());
        inputs[4] = float.Parse(Console.ReadLine());

        int evenCount = 0;
        int oddCount = 0;
        int positivesCount = 0;
        int negativesCount = 0;

        for (int i = 0; i < inputs.Length; i++)
        {
            if(inputs[i] % 2 == 0)
                evenCount += 1;
            else
                oddCount += 1;
            if(inputs[i] > 0)
                positivesCount += 1;
            if(inputs[i] < 0)
                negativesCount += 1;
        }

        System.Console.WriteLine($"{evenCount} valor(es) par(es)");
        System.Console.WriteLine($"{oddCount} valor(es) impar(es)");
        System.Console.WriteLine($"{positivesCount} valor(es) positivo(s)");
        System.Console.WriteLine($"{negativesCount} valor(es) negativo(s)");

    }

}