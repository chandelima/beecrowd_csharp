using System; 

class URI {

    static void Main(string[] args) { 

        double n1 = getNote();
        double n2 = getNote();
        
        double media = (n1 + n2) / 2;
        System.Console.WriteLine($"media = {media:F2}");
    }

    static double getNote() {
        double note = -1;

        while(note < 0 || note > 10) {
            note = double.Parse(Console.ReadLine());
            if(note < 0 || note > 10)
                System.Console.WriteLine("nota invalida");
        }

        return note;
    }
}