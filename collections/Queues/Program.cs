namespace A53Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Enfileirar("Van");
            Enfileirar("Kombi");
            Enfileirar("Guincho");
            Enfileirar("Pickup");
            PrintValues(pedagio);

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            PrintValues(pedagio);
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"{veiculo} entrou na fila");
            pedagio.Enqueue(veiculo);
        }

        private static void Desenfileirar()
        {
            if(pedagio.Any())
            {
                if(pedagio.Peek() == "Guincho")
                {
                    Console.WriteLine("O guincho está fazendo o pagamento");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"{veiculo} saiu da fila");
            }
        }

        private static void PrintValues(Queue<string> pedagio)
        {
            Console.WriteLine("-------- FILA --------");
            foreach(var veiculo in pedagio)
            {
                Console.WriteLine(veiculo);
            }
            Console.WriteLine();
        }
    }
}