using System; 

class URI {

    static void Main(string[] args) { 

		string[] rawString;
        int x, y;

		do {
			rawString = Console.ReadLine().Split(' ');
            x = int.Parse(rawString[0]);
            y = int.Parse(rawString[1]);
			
			if (x > 0 && y > 0)
				Console.WriteLine("primeiro");
			if (x < 0 && y > 0)
				Console.WriteLine("segundo");
			if (x < 0 && y < 0)
				Console.WriteLine("terceiro");
			if (x > 0 && y < 0)
				Console.WriteLine("quarto");
		} while (x != 0 && y != 0);

    }

}