using System; 

class URI {

    static void Main(string[] args) { 

        int input1 = int.Parse(Console.ReadLine());
        int input2 = int.Parse(Console.ReadLine());
        int sum = 0;


        if (input1 < input2) {
			for (int i = input1 + 1; i < input2; i++) {
				if (i % 2 != 0)
					sum += i;
			}
		} else {
			for (int i = input2 + 1; i < input1; i++) {
				if (i % 2 != 0)
					sum += i;
			}
		}

        System.Console.WriteLine(sum);
    }

}