using System.Collections.ObjectModel;

namespace Collections.Listas
{
    public class Curso
    {
        private IList<Aula> aulas;
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        private string instrutor;
        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public int TempoTotal
        {
            get
            {
                // int total = 0;
                // foreach(var aula in aulas)
                // {
                //     total += aula.Tempo;
                // }
                // return total;

                // LINQ = Language Integrated Query, Consulta Integrada à Linguagem
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal} , Aulas: {string.Join(",", aulas)} ";
        }
    }
}