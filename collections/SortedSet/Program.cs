namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Internamente, o SortedSet utiliza a estrutura de árvore binária para determinar a ordem dos valores
            // Não contêm chaves, porque não é uma coleção associativa. Os valores são a própria chave dos elementos
            // Implementing a SortedSet
            ISet<string> alunos = new SortedSet<string>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken"); // Não foi inserido e não lançou exceção
            alunos.Add("FABIO GUSHIKEN"); // Foi adicionado, sem erros

            Console.WriteLine("        ALUNOS");
            PrintValues(alunos);

            // Operações que podem ser realizadas com SortedSet
            ISet<string> outroConjunto = new HashSet<string>();
            outroConjunto.Add("Maria Aparecida");
            outroConjunto.Add("José Silva");
            outroConjunto.Add("Priscila Stuani");
            outroConjunto.Add("Clarice Oliveira");
            outroConjunto.Add("Vanessa Tonini");
            outroConjunto.Add("Anderson Miguel");
            Console.WriteLine("      OUTROCONJUNTO");
            PrintValues(outroConjunto);
            //Console.WriteLine(string.Join(",", outroConjunto));

            // Verificar se é subconjunto
            Console.WriteLine($"Alunos é subconjunto de outroConjunto? {alunos.IsSubsetOf(outroConjunto)}");

            Console.WriteLine($"OutroConjunto está contido em Alunos? {alunos.IsSupersetOf(outroConjunto)}");

            Console.WriteLine($"Alunos e outroConjunto contêm os mesmo elementos? {alunos.SetEquals(outroConjunto)}");
            Console.WriteLine("");

            // Remove o elemento de Aluno, se esse elemento também estiver presente no outroConjunto
            //ElementosPresentesSomenteNoConjuntoAlunos(alunos, outroConjunto);

            // Retorna os elementos comuns aos dois conjuntos
            //InterseccaoDosConjuntos(alunos, outroConjunto);

            // Exclui elementos presentes nos dois conjuntos
            //ElementosExclusivos(alunos, outroConjunto);

            // Une os dois conjuntos, sem que haja repetição dos elementos
            Uniao(alunos, outroConjunto);
        }

        private static void Uniao(ISet<string> alunos, ISet<string> outroConjunto)
        {
            // Modifica o conjunto atual para que ele contenha todos os elementos do conjunto atual e do outro conjunto, eliminando eventiais repetições
            alunos.UnionWith(outroConjunto);

            Console.WriteLine($"União dos conjuntos: ");
            PrintValues(alunos);
        }

        private static void ElementosExclusivos(ISet<string> alunos, ISet<string> outroConjunto)
        {
            // Modifica o conjunto atual para que ele contenha apenas elementos presentes em apenas um dos conjuntos
            alunos.SymmetricExceptWith(outroConjunto);

            Console.WriteLine($"Elementos que estão apenas em um dos conjuntos: ");
            PrintValues(alunos);
        }

        private static void InterseccaoDosConjuntos(ISet<string> alunos, ISet<string> outroConjunto)
        {
            alunos.IntersectWith(outroConjunto);

            Console.WriteLine($"Intersecção dos conjuntos: ");
            PrintValues(alunos);
        }

        private static void ElementosPresentesSomenteNoConjuntoAlunos(ISet<string> alunos, ISet<string> outroConjunto)
        {
            // Remove do conjunto Alunos qualquer elemento que também exista no outroConjunto.
            // Se o elemento foi comum aos dois conjuntos, ele será removido.
            alunos.ExceptWith(outroConjunto);

            Console.WriteLine($"Retorna os elementos que são exclusivos de Alunos: ");
            PrintValues(alunos);
        }

        private static void PrintValues(ISet<string> alunos)
        {
            foreach (string item in alunos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}