namespace bytebank
{
    public class LeitorDeArquivo
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            throw new FileNotFoundException();
            //Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            throw new IOException();
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}