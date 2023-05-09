﻿using System;
using System.Text;
using System.Collections.Generic;

namespace refatoracao.R52.ReplaceErrorCodeWithException.antes
{
    class Programa
    {
        void Main()
        {
            var contaCorrente = new ContaBancaria(TipoConta.ContaCorrente(), 100m);
            var poupanca = new ContaBancaria(TipoConta.Poupanca(), 300m);
            AplicarNaPoupanca(contaCorrente, poupanca, 50);
        }

        void AplicarNaPoupanca(ContaBancaria contaCorrente,
            ContaBancaria poupanca, decimal valor)
        {
            if (ContasNaoNulas(contaCorrente, poupanca))
            {
                throw new ArgumentNullException("Conta Corrente e " +
                    "Poupança não podem ser nulos");
            }

            try
            {
                contaCorrente.Sacar(valor);
            }
            catch (System.Exception exc)
            {
                
                throw;
            }

            poupanca.Depositar(valor);
        }

        private static bool ContasNaoNulas(ContaBancaria contaCorrente,
            ContaBancaria poupanca)
        {
            return contaCorrente == null || poupanca == null;
        }
    }

    class ContaBancaria
    {
        private readonly TipoConta tipoConta;
        public TipoConta TipoConta
        {
            get
            {
                return tipoConta;
            }
        }

        private decimal saldo;
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
        }

        public ContaBancaria(TipoConta tipoConta, decimal saldoInicial)
        {
            this.tipoConta = tipoConta;
            this.saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            this.saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            this.saldo += valor;
        }
    }

    class TipoConta
    {
        private static int CONTA_CORRENTE = 0;
        private static int POUPANCA = 1;
        private static int INVESTIMENTO = 2;

        public static TipoConta ContaCorrente() { return new TipoConta(CONTA_CORRENTE); }
        public static TipoConta Poupanca() { return new TipoConta(POUPANCA); }
        public static TipoConta Investimento() { return new TipoConta(INVESTIMENTO); }

        private readonly int codigoTipo;
        public int CodigoTipo
        {
            get
            {
                return codigoTipo;
            }
        }

        public TipoConta(int codigoTipo)
        {
            this.codigoTipo = codigoTipo;
        }
    }
}