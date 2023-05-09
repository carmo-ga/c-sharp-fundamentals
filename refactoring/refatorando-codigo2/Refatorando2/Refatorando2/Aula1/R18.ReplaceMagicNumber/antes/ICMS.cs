using System;

namespace refatoracao.R18.ReplaceMagicNumber.antes
{
    class Programa
    {
        void Main()
        {
            var valorImposto = ICMS.CalcularValor(1000, "SP");
        }
    }

    class ICMS
    {
        private const decimal aliquota_ICMS_padrao = 0.15m;
        private const decimal aliquota_ICMS_SP = 0.18m;
        private const string uf_SP = "SP";

        public static decimal CalcularValor(decimal valorProdutos, string uf)
        {
            if (valorProdutos < 0)
            {
                throw new ArgumentOutOfRangeException("Valor não pode ser negativo");
            }

            if (uf == uf_SP)
            {
                return valorProdutos * aliquota_ICMS_SP;
            }
            return valorProdutos * aliquota_ICMS_padrao;
        }
    }
}
