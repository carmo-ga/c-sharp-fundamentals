using System.Collections.ObjectModel;

namespace A32SetNoModelo
{
    public class Curso
    {
        // Alunos é um ISet. Alunos deve retornar ReadOnlyCollection
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

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

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            foreach(var aluno in alunos)
            {
                if(aluno.NumeroMatricula == numeroMatricula)
                {
                    return aluno;
                }
            }
            throw new Exception("Matrícula não encontrada " + numeroMatricula);
        }
    }
}