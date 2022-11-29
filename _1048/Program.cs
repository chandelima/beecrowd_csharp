using System; 

class URI {

    static void Main(string[] args) { 

        float oldSalary = float.Parse(Console.ReadLine());
        float increase = 0f;

        if(oldSalary <= 400.00f)
            increase = 15;
        if(oldSalary >= 400.01f && oldSalary <= 800.00f)
            increase = 12;
        if(oldSalary >= 800.01f && oldSalary <= 1200.00f)
            increase = 10;
        if(oldSalary >= 1200.01f && oldSalary <= 2000.00f)
            increase = 7;
        if(oldSalary > 2000.01f)
            increase = 4;

        float readjustment = oldSalary * increase / 100.00f;
        float newSalary = oldSalary + readjustment;

        Console.WriteLine($"Novo salario: {newSalary:F2}");
        Console.WriteLine($"Reajuste ganho: {readjustment:F2}");
        Console.WriteLine($"Em percentual: {increase:F0} %");
    }

}