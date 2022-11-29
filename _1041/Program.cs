using System; 

class URI {

    static void Main(string[] args)
    {
        int[] quadrant = new int[4];

        string[] rawConsole = Console.ReadLine().Split();
        float inputX = float.Parse(rawConsole[0]);
        float inputY = float.Parse(rawConsole[1]);

        if(inputX + inputY == 0.0) {
            Console.WriteLine("Origem");

        } else {
            if(inputX > 0) {
                quadrant[0]++;
                quadrant[3]++;
            } else {
                quadrant[1]++;
                quadrant[2]++;
            }

            if(inputY > 0) {
                quadrant[0]++;
                quadrant[1]++;
            } else {
                quadrant[2]++;
                quadrant[3]++;
            }

            int[] biggerQuadrant = new int[quadrant.Length];
            Array.Copy(quadrant, biggerQuadrant, quadrant.Length);
            Array.Sort(biggerQuadrant);

            if(inputX + inputY == 0.0)
            {
                Console.WriteLine("Origem");
            } else if (inputY == 0.0)
            {
                Console.WriteLine("Eixo X");
            } else if (inputX == 0.0)
            {
                Console.WriteLine("Eixo Y");
            } else
            {
                for (int i = 0; i < quadrant.Length; i++)
                {
                    if (biggerQuadrant[3] == quadrant[i])
                        Console.WriteLine($"Q{i + 1}");
                }
            }
        }
    }
}