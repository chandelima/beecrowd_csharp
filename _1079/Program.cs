using System; 

class URI {

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            
            float v1 = float.Parse(values[0]);
            float v2 = float.Parse(values[1]);
            float v3 = float.Parse(values[2]);
            
            calcMedia(v1, v2, v3);
       }
    }

    static void calcMedia(float n1, float n2, float n3) {
        float media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
        Console.WriteLine($"{media:F1}");
    }
}