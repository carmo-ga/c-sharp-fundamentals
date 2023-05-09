using System;

class Programa
{
    static void Main(string[] args)
    {
        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
       
        string textoAdicional;

        if(acompanhado == true)
        {
            textoAdicional = "João está acompanhado.";
        }
        else
        {
            textoAdicional = "João não está acompanhado.";
        }


        if(idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional + " Acesso permitido!");
        }
        else
        {
            Console.WriteLine(textoAdicional + " Acesso negado!");
        }
    }
}