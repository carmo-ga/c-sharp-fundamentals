﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using refatoracao.R60.ExtractInterface.antes;

namespace Refactoring3.Aula5.R60.ExtractInterface.antes
{
    class Program
    {

        void Main()
        {
            IFormatter formatadorCNPJ = new CNPJFormatter();
            string codigoCNPJ = "12345678000099";
            ImprimirCodigoFormatado(formatadorCNPJ, codigoCNPJ);

            IFormatter formatadorCPF = new CPFFormatter();
            string codigoCPF = "12345678001";
            ImprimirCodigoFormatado(formatadorCPF, codigoCPF);

        }

        private static void ImprimirCodigoFormatado(IFormatter formatador, string codigo)
        {
            Console.WriteLine($"Código formatado: {formatador.Format(codigo)}");
        }
    }
}