using System; 

class URI {

    static void Main(string[] args) { 

        string[] stringRaw = Console.ReadLine().Split(' ');
        Array.Sort(stringRaw);

        float a = float.Parse(stringRaw[0]);
        float b = float.Parse(stringRaw[1]);
        float c = float.Parse(stringRaw[2]);

        if(a >= (b+c) || b >= (a+c) || c >= (a+b)) {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else {
            if(a*a == (b*b + c*c) || b*b == (a*a + c*c) || c*c == (a*a + b*b))
            Console.WriteLine("TRIANGULO RETANGULO");
            else if(a*a > (b*b + c*c) || b*b > (a*a + c*c) || c*c > (a*a + b*b))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if(a == b && a == c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            else if((a == b && a != c)  || (a == c && a != b) || (b == c && b != a))
                Console.WriteLine("TRIANGULO ISOSCELES");
        }
            
    }

}