using System; 

class URI {

    static void Main(string[] args) { 

        int operation = 1; // 1=sim, 2= nao
        float n1, n2, media;
        
        do
        {
            if (operation == 1) {
                n1 = getNote();
                n2 = getNote();

                media = (n1 + n2)/2;
                System.Console.WriteLine($"media = {media:F2}");
            }

            System.Console.WriteLine($"novo calculo (1-sim 2-nao)");
            operation = int.Parse(Console.ReadLine());

        } while (operation != 2);

    }

    static float getNote() {
        float note;

        do
        {
            note = float.Parse(Console.ReadLine());

            if(note < 0 || note > 10)
                System.Console.WriteLine("nota invalida");

        } while (note < 0 || note > 10);

        return note;
    }

}