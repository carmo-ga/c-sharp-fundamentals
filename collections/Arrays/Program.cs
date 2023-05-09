namespace Collections.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";
            string aulaPadroes = "Design Patterns";
            string aulaTeste = "Teste";

            // string[] aulas = new string[]
            // {
            //     aulaIntro,
            //     aulaModelando,
            //     aulaSets,
            //     aulaPadroes,
            //     aulaTeste
            // };

            string[] aulas = new string[5];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;
            aulas[3] = aulaPadroes;
            aulas[4] = aulaTeste;

            Imprimir(aulas);

            // Console.WriteLine(aulas[0]); // Primeiro elemento do array
            // Console.WriteLine(aulas[aulas.Length - 1]); // Último elemento do array

            aulaIntro = "Trabalhando com Arrays"; // Não ocore mudança, pois o array armazena um cópia do valor de aulaIntro

            aulas[0] = "Trabalhando com Arrays"; // Ocorre alteração diretamente no índice do array
            Imprimir(aulas);

            // Retorna o índice da primeira ocorrência
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
            // Retorna o índice da última ocorrência
            Console.WriteLine("Aula modelando está no índice " + Array.LastIndexOf(aulas, aulaModelando));

            // Reverte totalmente o array
            Array.Reverse(aulas);
            Imprimir(aulas);

            // Reverte totalmente o array
            Array.Reverse(aulas);
            Imprimir(aulas);

            // Redimensiona o array
            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            Array.Resize(ref aulas, 4);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);
            
            // Ordena o array
            Array.Sort(aulas);
            Imprimir(aulas);

            // Copiar parte do array atual para um novo array
            string[] copia = new string[2];
            Array.Copy(aulas, 2, copia, 0, 2);
            Imprimir(copia);

            // Copiar todo o array atual para um novo array
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            // Limpa o valor de elementos do array (não exclui o índice)
            Array.Clear(clone, 2, 2);
            Imprimir(clone);

        }

        private static void Imprimir(string[] aulas)
        {
            // foreach(var aula in aulas)
            // {
            //     Console.WriteLine(aula);
            // }

            for(int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}