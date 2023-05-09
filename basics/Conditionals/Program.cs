using System;

class Programa
{
    static void Main(string[] args)
    {
        int idadeJoao = 16;
        int quantidadePessoas = 2;

        // If
        // if(idadeJoao >= 18)
        // {
        //     Console.WriteLine("Acesso permitido.");
        // }
        // else
        // {
        //     if(quantidadePessoas > 1)
        //     {
        //         Console.WriteLine("Acompanhado. Acesso permitido.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Acesso negado.");
        //     }
        // }


        //if(idadeJoao >= 18 || quantidadePessoas > 1)
        // if(idadeJoao >= 18 && quantidadePessoas > 1)
        // {
        //     Console.WriteLine("Acompanhado. Acesso permitido.");
        // }
        // else
        // {
        //     Console.WriteLine("Acesso negado.");
        // }

        // Booleans
        bool acompanhado = quantidadePessoas > 1;
        bool grupo = true;

        if(idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Acompanhado. Acesso permitido.");
        }
        else
        {
            Console.WriteLine("Acesso negado.");
        }
    }
}