using System; 

class URI {

    static void Main(string[] args) { 

        float[] inputs = new float[6];

        inputs[0] = float.Parse(Console.ReadLine());
        inputs[1] = float.Parse(Console.ReadLine());
        inputs[2] = float.Parse(Console.ReadLine());
        inputs[3] = float.Parse(Console.ReadLine());
        inputs[4] = float.Parse(Console.ReadLine());
        inputs[5] = float.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < inputs.Length; i++)
        {
            if(inputs[i] > 0)
                count += 1;
        }

        System.Console.WriteLine($"{count} valores positivos");

    }

}