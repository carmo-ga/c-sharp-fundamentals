namespace A32SetNoModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            // Aluno tem matrícula
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            // Matriculando o aluno ao curso, através do método Matricula
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            // Imprimindo os alunos matriculados
            // foreach (var aluno in csharpColecoes.Alunos)
            // {
            //     Console.WriteLine(aluno); // Imprime o namespace e o nome da classe

            // }

            // Verificar se um determinado aluno está matriculado
            Console.Write($"O aluno a1 {a1.Nome} está matriculado? ");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            // Instanciar novo alunos com os mesmos dados de a1 e verificar se está matriculado
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine($"Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini)); // Resultado: False, a segunda instância não é reconhecida como sendo igual à primeira

            // E a1 == Tonini?
            Console.Write("a1 == Tonini? ");
            Console.WriteLine(a1 == tonini); // False, porque são instâncias diferentes

            // Comparando a instância a1 com a instância tonini
            Console.Write("a1 is equals Tonini? ");
            Console.WriteLine(a1.Equals(tonini)); // False, mas depois de sobrescrever o método Equals, passa a ser True.

            // Busca de aluno por número de matrícula
            Console.Write("Quem é o aluno com matrícula 5617? ");
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine(aluno5617);
        }
    }
}