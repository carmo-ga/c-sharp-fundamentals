namespace Collections.Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // LISTA SOMENTE LEITURA - ORDENANDO E TOTALIZANDO
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            //Imprimir(csharpColecoes.Aulas);

            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));
            Imprimir(csharpColecoes.Aulas);

            // Não ordena lista com IList
            //csharpColecoes.Aulas.Sort();

            // Copia a lista para outra lista que permita ordenação
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            // Ordena a lista copiada
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            // Tempo total das aulas
            Console.WriteLine("Duração total " + csharpColecoes.TempoTotal);

            // Imprime detalhes do curso
            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            foreach(var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}