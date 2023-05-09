using System;
using System.Text;
using System.Collections.Generic;

namespace refatoracao.R62.FormTemplateMethod.antes
{
    class Program
    {
        void Main()
        {
            var cliente = new Cliente();

            //....
            //....

            var resumo = new Resumo(cliente).GetResumo();
            var resumoHTML = new ResumoHTML(cliente).GetResumo();
        }
    }

    class Cliente
    {
        private IList<Locacao> locacoes;
        public IList<Locacao> Locacoes
        {
            get { return locacoes; }
            set { locacoes = value; }
        }

        private double valorTotal;
        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private double pontosDeFidelidade;
        public double PontosDeFidelidade
        {
            get { return pontosDeFidelidade; }
            set { pontosDeFidelidade = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }

    abstract class BaseResumo
    {
        protected readonly Cliente cliente;

        public BaseResumo(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public string GetResumo()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine(GetTitulo());
            foreach (var locacao in cliente.Locacoes)
            {
                resultado.AppendLine(GetDetalhe(locacao));
            }
            resultado.AppendLine(GetDebitos());
            resultado.AppendLine(GetPontos());
            return resultado.ToString();
        }

        protected abstract string GetTitulo();

        protected abstract string GetDetalhe(Locacao locacao);

        protected abstract string GetDebitos();

        protected abstract string GetPontos();
    }

    internal class ResumoHTML : BaseResumo
    {
        public ResumoHTML(Cliente cliente) : base(cliente)
        {
        }

        protected override string GetTitulo()
        {
            return "<h1>Locações de <em>" + cliente.Nome + "</em></h1>";
        }

        protected override static string GetDetalhe(Locacao locacao)
        {
            return locacao.Filme.Titulo + "<br/>";
        }

        protected override string GetDebitos()
        {
            return "<p> Você deve: <em>R$ " + cliente.ValorTotal.ToString() + "</em></p>";
        }

        protected override string GetPontos()
        {
            return "Você ganhou: " + cliente.PontosDeFidelidade.ToString() + "</em> pontos.";
        }
    }

    internal class Resumo : BaseResumo
    {

        public Resumo(Cliente cliente) : base(cliente)
        {
        }

        protected override string GetTitulo()
        {
            return "Resumo de locações de " + cliente.Nome;
        }

        protected override static string GetDetalhe(Locacao locacao)
        {
            return "\t" + locacao.Filme.Titulo;
        }

        protected override string GetDebitos()
        {
            return "Total devido: " + cliente.ValorTotal.ToString();
        }

        protected override string GetPontos()
        {
            return $"Você ganhou: {cliente.PontosDeFidelidade.ToString()} pontos";
        }
    }

    class Locacao
    {
        private Filme filme;

        public Filme Filme
        {
            get { return filme; }
            set { filme = value; }
        }
    }

    class Filme
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
    }
}
