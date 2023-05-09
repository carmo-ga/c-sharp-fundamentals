using System;

class Programa
{
    static void Main(string[] args)
    {
        // Char
        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(89 + 1);
        Console.WriteLine(letra);

        // String
        string primeiraFrase = "cadeia de caracteres";
        Console.WriteLine("Esta é uma " + primeiraFrase);

        // Empty char
        // letra = ''; // Wrong
        letra = ' ';
        Console.WriteLine(letra);

        string lProgramacao = @"Linguagens de Programação:
- Go
- C#
- Python
- Java";
        Console.WriteLine(lProgramacao);
    }
}