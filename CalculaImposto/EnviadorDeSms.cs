namespace CalculaImposto
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Envia nota fiscal por SMS.");
        }
    }
}