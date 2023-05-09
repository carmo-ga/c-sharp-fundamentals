// namespace Collections.Listas
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {

//             // LISTA DE OBJETOS
//             var aulaIntro = new Aula("Introdução às Coleções", 20);
//             var aulaModelando = new Aula("Modelando a Classe Aula", 18);
//             var aulaSets = new Aula("Trabalhando com Conjuntos", 16);
//             var aulaPadroes = new Aula("Design Patterns", 14);
//             var aulaTeste = new Aula("Teste", 12);

//             List<Aula> aulas = new List<Aula>();
//             aulas.Add(aulaIntro);
//             aulas.Add(aulaModelando);
//             aulas.Add(aulaSets);
//             aulas.Add(aulaPadroes);
//             aulas.Add(aulaTeste);
//             //aulas.Add("Conclusão");

//             Imprimir(aulas);

//             // Ordena a lista (ordem alfabética)
//             aulas.Sort();
//             Imprimir(aulas);

//             // Ordena a lista (por tenpo)
//             aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
//             Imprimir(aulas);
//         }

//         private static void Imprimir(List<Aula> aulas)
//         {
//             foreach(var aula in aulas)
//             {
//                 Console.WriteLine(aula);
//             }
//         }
//     }

//     class Aula : IComparable
//     {
//         private string titulo;
//         private int tempo;

//         public string Titulo { get => titulo; set => titulo = value; }
//         public int Tempo { get => tempo; set => tempo = value; }

//         public Aula(string titulo, int tempo)
//         {
//             this.titulo = titulo;
//             this.tempo = tempo;
//         }

//         public override string ToString()
//         {
//             return $"[Título: {titulo}, Duração: {tempo}]";
//         }

//         public int CompareTo(object obj)
//         {
//             Aula that = obj as Aula;
//             return this.titulo.CompareTo(that.titulo);
//         }
//     }
// }