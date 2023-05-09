namespace A41Dicionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            // Matriculando o aluno ao curso, através do método Matricula
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            foreach (var aula in csharpColecoes.Aulas)
            {
                Console.WriteLine(aula);
            }

            // Verificar se um determinado aluno está matriculado
            Console.Write($"O aluno a1 {a1.Nome} está matriculado? ");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            // Busca de aluno por número de matrícula
            Console.Write("Quem é o aluno com matrícula 5617? ");
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine(aluno5617);

            // Busca de aluno por número de matrícula que não existe
            Console.Write("Quem é o aluno com matrícula 5618? ");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5618));

            // Adicionando um novo aluno com chave (matrícula) repetida
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            // csharpColecoes.Matricula(fabio); // Erro, o dicionário não permite mais de um valor com a mesma chave

            // Substitui o valor (Aluno) da chave informada.
            csharpColecoes.SubstituiAluno(fabio);
            Console.Write("Quem é o aluno com matrícula 5617 agora? ");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(5617));

            foreach(KeyValuePair<int, Aluno> aluno in csharpColecoes.DicionarioAlunos)
            {
                Console.WriteLine(aluno);
            }

        }
    }
}