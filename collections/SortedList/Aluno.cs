namespace SortedList
{
    public class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int numeroMatricula;
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        public Aluno(string nome, int numeroMatricula)
        {
            Nome = nome;
            NumeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if(outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome);
        }

        // A rapidez da busca depende do Código de Dispersão
        // Importante!
        // Dois objetos que são iguais possuem o mesmo hash code.
        // PORÉM, o contrário não é verdadeiro
        // Dois objetos com o mesmo hash code não são necessariamente iguais.
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}