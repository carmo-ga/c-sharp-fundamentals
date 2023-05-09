namespace A51LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "Abacate", "Banana", "Caqui", "Damasco", "Figo"
            };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            // Em uma Linked List
            // - Os elementos não precisam estar em sequência na memória
            // Cada elemento sabe quem é o anterior e o próximo
            // Cada elemento é um nó que contém um valor

            // Instanciando uma nova lista ligada (de dias da semana)
            LinkedList<string> dias = new LinkedList<string>();
            LinkedListNode<string> d4 = dias.AddFirst("Quarta-feira");
            Console.WriteLine("d4.Value: " + d4.Value);

            // É possível adicionar itens de quatro formas:
            // 1. Como primeiro nó
            // 2. Como último nó
            // 3. Antes de um nó conhecido
            // 4. Depois de um nó conhecido

            // Adicionando segunda-feira antes da quarta-feira
            LinkedListNode<string> d2 = dias.AddBefore(d4, "Segunda-feira");
            // Agora d2 e d4 estão ligados, sendo que:
            // - d2.Next é igual a d4
            // - d4.Previous é igual a d2

            // Adicionando terça-feira depois de segunda-feira
            LinkedListNode<string> d3 = dias.AddAfter(d2, "Terça-feira");
            // Agora os "ponteiros", ou referência de d2 e d4 foram redirecionados para d3.

            // Adicionando sexta-feira depois de quarta-feira
            LinkedListNode<string> d6 = dias.AddAfter(d4, "Sexta-feira");

            // Adicionando sábado depois de sexta-feira
            LinkedListNode<string> d7 = dias.AddAfter(d6, "Sábado");

            // Adicionando quinta-feira antes de sexta-feira
            LinkedListNode<string> d5 = dias.AddBefore(d6, "Quinta-feira");

            // Adicionando domingo antes de segunda-feira
            LinkedListNode<string> d1 = dias.AddBefore(d2, "Domingo");

            // dias[1]; // LinkedList NÃO dá suporte ao acesso de índice, por isso é possível fazer um laço foreach, mas não um for.
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            LinkedListNode<string> quarta = dias.Find("Quarta-feira");
            Console.WriteLine(quarta.Value);

            // É possível remover um elemento tanto pelo valor quanto pela referência:
            // dias.Remove("Quarta-feira"); ou dias.Remove(d4);
            dias.Remove("Quarta-feira");

            foreach (var dia in dias) { Console.WriteLine(dia); }
        }
    }
}