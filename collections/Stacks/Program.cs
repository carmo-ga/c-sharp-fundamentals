namespace A52Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Navegador navegador = new Navegador();

            navegador.NavegarPara("www.google.com");
            navegador.NavegarPara("www.caelum.com.br");
            navegador.NavegarPara("www.alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Proximo();
            navegador.Anterior();
            //navegador.Anterior();
            
            navegador.Proximo();
            navegador.Proximo();
        }
    }

    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string paginaAtual = "vazia";

        public Navegador()
        {
            Console.WriteLine($"Página atual: {paginaAtual}");
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(paginaAtual);
            paginaAtual = url;
            Console.WriteLine($"Página atual: {paginaAtual}");
        }

        internal void Anterior()
        {
            Console.WriteLine("-------------- Stack Anterior -----------------");
            PrintValues(historicoAnterior);

            if(historicoAnterior.Any())
            {
                historicoProximo.Push(paginaAtual);
                paginaAtual = historicoAnterior.Pop();
                Console.WriteLine($"Página atual: {paginaAtual}");
            }
        }

        internal void Proximo()
        {
            Console.WriteLine("-------------- Stack Próximo -----------------");
            PrintValues(historicoProximo);

            if(historicoProximo.Any())
            {
                historicoAnterior.Push(paginaAtual);
                paginaAtual = historicoProximo.Pop();
                Console.WriteLine($"Página atual: {paginaAtual}");
            }
        }

        internal void PrintValues(Stack<string> stack)
        {
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}