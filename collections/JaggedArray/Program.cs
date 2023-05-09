namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Família 1: Família Flintstones
            // Família 2: Família Simpsons
            // Família 3: Família Dona Florinda

            // string[,] familias = new string[3, 2] // Não funciona, porque os arrays têm tamanhos variados
            // {
            //     Não é possível iniciar um jagged array dessa forma
            //     {"Fred", "Wilma", "Pedrita"},
            //     {"Homer", "Marge", "Lisa", "Bart", "Maggie"},
            //     {"Florinda", "Kiko"}
            // };

            // Utilizando um Jagged Array, ou array (de tamanho) irregular
            string[][] familias = new string[3][];

            familias[0] = new string[] {"Fred", "Wilma", "Pedrita"};
            familias[1] = new string[] {"Homer", "Marge", "Lisa", "Bart", "Maggie"};
            familias[2] = new string[] {"Florinda", "Kiko"};

            foreach(string[] familia in familias)
            {
                Console.WriteLine(string.Join(", ", familia));
            }
        }
    }
}