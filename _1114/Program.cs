using System; 

class URI {

    static void Main(string[] args) { 

        int password;

        do
        {
            password = int.Parse(Console.ReadLine());

            if(password == 2002)
                Console.WriteLine("Acesso Permitido");
            else
                Console.WriteLine("Senha Invalida");

        } while (password != 2002);
    }

}