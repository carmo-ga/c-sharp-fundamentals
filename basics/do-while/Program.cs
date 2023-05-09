using System;

class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000;

        // Rendimento de 0,5% ao mês
        
        int mes = 1;
        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " o valor total é: R$ " + investimento);
            mes++;
        }
    }   
}