using System;

class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000;

        // Rendimento de 0,5% ao mês
        // for(int mes = 1; mes <= 12; mes++)
        // {
        //     investimento = investimento * 1.005;
        //     Console.WriteLine("No mês " + mes + " o valor total é: R$ " + investimento);
        // }

        // ------- Encadeamento de laço for
        double fatorRendimento = 1.005;
        for(int anos = 1; anos <= 5; anos++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento = investimento * fatorRendimento;
            }
            fatorRendimento = fatorRendimento + 0.001;

        }
        Console.WriteLine("Após cinco anos o valor total será: R$ " + investimento);
    }   
}