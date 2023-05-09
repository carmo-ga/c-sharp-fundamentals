using System.Collections.ObjectModel;

namespace A41Dicionarios
{
    public class Curso
    {
        // Dicionário de alunos
        private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
        public IDictionary<int, Aluno> DicionarioAlunos
        {
            get
            {
                return dicionarioAlunos;
            }
        }



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

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }


        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        internal void Matricula(Aluno aluno)
        {
            // Adiciona no Set de alunos
            this.alunos.Add(aluno);
            // Cria a relação no Dictionary
            this.dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numeroMatricula)
        {
            //return this.dicionarioAlunos[numeroMatricula]; // Gera exceção quando o chave buscada não existe

            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
            return aluno;
        }

        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumeroMatricula] = aluno;
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal} , Aulas: {string.Join(",", aulas)} ";
        }
    }
}