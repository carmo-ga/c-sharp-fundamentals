namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Internamente, um SortedDictionary tem uma coleção de chaves (KeyCollection) e uma coleção de valores (ValueCollection)
            // As chaves têm uma estrutura de árvore binária, então um elemento aponta qual elemento está antes ou depois dele, permitindo a ordenação. E há um outro apontamento para a coleção de valores.
            // Se comparado com uma SortedList, as buscas, inserções e remoções são feitas de forma mais rápida
            // Implementing a SortedDictionary
            IDictionary<string, Aluno> sorted = new SortedDictionary<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            foreach (KeyValuePair<string, Aluno> item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}