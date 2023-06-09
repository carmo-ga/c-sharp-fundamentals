﻿using System;

namespace refatoracao.R04.InlineTemp.antes
{
    class CalculadoraDePrecos
    {
        bool TemDesconto(Pedido pedido)
        {
            return (pedido.ValorProdutos() > 1000);
        }
    }

    class Pedido
    {
        private readonly DateTime clienteDesde;
        private readonly decimal valorProdutos;

        public Pedido(DateTime clienteDesde, decimal valorProdutos)
        {
            this.clienteDesde = clienteDesde;
            this.valorProdutos = valorProdutos;
        }

        public decimal ValorProdutos()
        {
            return valorProdutos;
        }

        public bool TemDesconto()
        {
            //aqui NÃO É um bom exemplo para inline method!
            bool clienteHaMaisDe5Anos = (DateTime.Today.Subtract(clienteDesde).TotalDays / 365) >= 5;
            bool compraEspecial = valorProdutos > 1000;
            return clienteHaMaisDe5Anos && compraEspecial;
        }
    }
}
