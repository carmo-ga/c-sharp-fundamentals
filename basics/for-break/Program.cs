using System;
class Programa
{
    static void Main(string[] args)
    {

        // --------- Com if e com break
        for(int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for(int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write("*");
                if(contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine(" ");
        }

        // --------- Sem if e sem break
        // for(int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        // {
        //     for(int contadorColunas = 0; contadorColunas <= contadorLinhas; contadorColunas++)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.WriteLine(" ");
        // }



        // --------- Exercício: Múltiplos de 3 entre 1 e 100
        // for(int numero = 1; numero <= 100; numero++)
        // {
        //     if(numero % 3 == 0)
        //     {
        //         Console.WriteLine("O " + numero + " é múltiplo de 3.");
        //     }
        // }

        // --------- Exercício: resolução alternativa
        // Console.WriteLine("Os números a seguir são múltiplos de 3: ");
        // for(int numero = 3; numero < 100; numero += 3)
        // {
        //     if(numero % 3 == 0)
        //     {
        //         Console.Write(numero + " ");
        //     }
        // }


        // --------- Exercício: fatorial
        // int fatorial = 1;
        // for(int numero = 1; numero <= 10; numero++)
        // {
        //     fatorial = fatorial * numero;
        //     Console.WriteLine("O fatorial de " + numero + " é " + fatorial);
        // }
    }   
}