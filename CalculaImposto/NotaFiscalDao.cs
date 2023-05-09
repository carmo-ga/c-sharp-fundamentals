namespace CalculaImposto
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Salva nota fiscal no banco de dados.");
        }
    }
}