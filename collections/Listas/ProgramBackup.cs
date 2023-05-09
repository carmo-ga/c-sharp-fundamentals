// using System;
// using System.Text;
// using System.Linq;
// using System.Collections.Generic;

// namespace Collections.Listas
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // LISTAS - BÁSICO
//             string aulaIntro = "Introdução às Coleções";
//             string aulaModelando = "Modelando a Classe Aula";
//             string aulaSets = "Trabalhando com Conjuntos";
//             string aulaPadroes = "Design Patterns";
//             string aulaTeste = "Teste";

//             // List<string> aulas = new List<string>
//             // {
//             //     aulaIntro,
//             //     aulaModelando,
//             //     aulaSets,
//             //     aulaPadroes, 
//             //     aulaTeste
//             // };

//             List<string> aulas = new List<string>();
//             aulas.Add(aulaIntro);
//             aulas.Add(aulaModelando);
//             aulas.Add(aulaSets);
//             aulas.Add(aulaPadroes);
//             aulas.Add(aulaTeste);

//             Imprimir(aulas);

//             // Primeiro elemento da lista
//             Console.WriteLine("A primeira aula é " + aulas[0]);
//             Console.WriteLine("A primeira aula é " + aulas.First());
//             // Último elemento da lista
//             Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
//             Console.WriteLine("A última aula é " + aulas.Last());

//             // Trocar nome do primeiro elemento da lista
//             aulas[0] = "Trabalhando com Listas";
//             Imprimir(aulas);

//             // Primeira ocorrência (da palavra "Trabalhando") na lista
//             Console.WriteLine("A primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));

//             // Última ocorrência (da palavra "Trabalhando") na lista
//             Console.WriteLine("A última aula 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));

//             // Primeira ocorrência (da palavra "Conclusão") na lista
//             // Resultado nulo, porque a palavra não existe na lista. O método FirstOrDefault() evita um erro
//             Console.WriteLine("A primeira aula 'Conclusão' é: " + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

//             // Reverte a ordem da lista
//             aulas.Reverse();
//             Imprimir(aulas);

//             // Remove elemento de uma posição específica da lista
//             aulas.RemoveAt(aulas.Count - 1);
//             Imprimir(aulas);

//             // Adiciona elemento na lista
//             aulas.Add("Conclusão");
//             Imprimir(aulas);

//             // Ordena a lista (ordem alfabética)
//             aulas.Sort();
//             Imprimir(aulas);

//             // Copia os dois últimos elementos da lista
//             List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
//             Imprimir(copia);

//             // Clona a lista
//             List<string> clone = new List<string>(aulas);
//             Imprimir(clone);

//             // Remove os dois últimos elementos da lista
//             clone.RemoveRange(clone.Count - 2, 2);
//             Imprimir(clone);
//         }

//         private static void Imprimir(List<string> aulas)
//         {
//             // foreach(var aula in aulas)
//             // {
//             //     Console.WriteLine(aula);
//             // }

//             // for(int i = 0; i < aulas.Count; i++)
//             // {
//             //     Console.WriteLine(aulas[i]);
//             // }

//             aulas.ForEach(aula =>
//             {
//                 Console.WriteLine(aula);
//             });
//             Console.WriteLine("---------------------------------------------------------");
//         }
//     }
// }