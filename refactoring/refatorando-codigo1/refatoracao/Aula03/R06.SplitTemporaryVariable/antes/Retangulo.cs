﻿namespace refatoracao.Aula03.R06.SplitTemporaryVariable.antes
{
    class Retangulo
    {
        public Retangulo(double altura, double largura)
        {
            double perimetro = 2 * (altura + largura);
            System.Console.WriteLine($"Perímetro: {perimetro}");

            double area = altura * largura;
            System.Console.WriteLine($"Área: {area}");
        }
    }
}
