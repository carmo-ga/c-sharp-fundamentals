using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario;

        long x;
        x = 20000000000000000;

        short y;
        y = 16000;

        float altura = 1.62f;

        // Outputs
        Console.WriteLine("Long: " + x);
        Console.WriteLine("Short: " + y);
        Console.WriteLine("Float: " + altura);
        Console.WriteLine("Salário (double): " + salario);
        Console.WriteLine("Salário (int): " + salarioInteiro);
        Console.WriteLine("Tecle para continuar");
        Console.ReadLine();
    }
}