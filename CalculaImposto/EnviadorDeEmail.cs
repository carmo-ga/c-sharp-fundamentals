namespace CalculaImposto
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Envia nota fiscal por e-mail.");
        }
    }
}