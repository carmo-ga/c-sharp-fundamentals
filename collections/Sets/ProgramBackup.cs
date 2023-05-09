// namespace A31OPoderDosSets
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // SETS = CONJUNTOS
//             // 1. Não permite duplicidade
//             // 2. Os elementos não são mantidos em ordem específica

//             // Declarando set de alunos
//             ISet<string> alunos = new HashSet<string>();

//             // Adicionando alunos ao set
//             alunos.Add("Vanessa Tonini");
//             alunos.Add("Ana Losnak");
//             alunos.Add("Rafael Nercessian");

//             // Imprime o set de alunos
//             Console.WriteLine(alunos); // Não imprime cada um dos alunos
//             Console.WriteLine(string.Join(", ", alunos));

//             alunos.Add("Priscila Stuani");
//             alunos.Add("Rafael Rollo");
//             alunos.Add("Fabio Gushiken");
//             Console.WriteLine(string.Join(", ", alunos));

//             // Removendo um aluno
//             alunos.Remove("Ana Losnak");
//             // Adicionando um novo aluno
//             alunos.Add("Marcelo Oliveira"); // Não há posição definida/garantida para o novo aluno
//             Console.WriteLine(string.Join(", ", alunos));

//             // Adicionando um mesmo aluno
//             alunos.Add("Fabio Gushiken");
//             Console.WriteLine(string.Join(", ", alunos)); // Não houve duplicidade. O elemento já existente não foi adicionado.
            
//             // ------- Diferença entre lista e set
//             // É possível fazer busca mais rápidas em um set do que em uma lista
//             // Ao buscar um elemento em um set, é utilizada uma tabela de espalhamento, que torna a busca mais rápida
//             // O set permite, mesmo em uma escala grande de elementos, boa performance em busca, mas exige um consumo de memória maior que uma lista.

//             // Ordenando um set
//             //alunos.Sort(alunos); // ISet não contém definição para Sort

//             // Copiando o set (para poder ordená-lo)
//             List<string> alunosEmLista = new List<string>(alunos);
//             alunosEmLista.Sort();
//             Console.WriteLine(string.Join(", ", alunosEmLista));
//         }
//     }
// }