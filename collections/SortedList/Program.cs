namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implementing a Dictionary
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa Tonini", 34672));
            alunos.Add("AL", new Aluno("Ana Losnak", 5617));
            alunos.Add("RN", new Aluno("Rafael Nercessian", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));
            Console.WriteLine("--------------------- Dictionary ---------------------");
            PrintValues(alunos);

            // Removendo um aluno
            alunos.Remove("AL");
            // Adicionando um novo aluno
            alunos.Add("MO", new Aluno("Marcelo", 12345)); // Não se sabe exatamente a posição que o item vai ocupar
            PrintValues(alunos);

            // Internamente, uma SortedList trabalha com duas listas(IList): uma para as chaves e outra para os valores
            // Ao acrescentar novos valores ao dicionário, as chaves vão sendo automaticamente ordenadas 
            // Implementing a SortedList, which implements a IDictionary<TKet, TValue>
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));
            Console.WriteLine("--------------------- Sorted List ---------------------");
            PrintValues(sorted);
        }

        private static void PrintValues(IDictionary<string, Aluno> alunos)
        {
            foreach(KeyValuePair<string, Aluno> aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine();
        }
    }
}