using System;
using System.Text;
using System.Collections.Generic;

namespace refatoracao.R61.CollapseHierarchy.antes
{
    class Programa
    {
        void Main()
        {
            var funcionario = new Funcionario("Walter White", "555-12345", "666-65432");
        }
    }

    public class Funcionario
    {
        public string Nome { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }
        public string CodigoFuncional { get; set; }

        public Funcionario(string nome, string telefoneFixo, string celular)
        {
            Nome = nome;
            TelefoneFixo = telefoneFixo;
            Celular = celular;
        }
    }
}