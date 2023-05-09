namespace ChainOfResponsibility
{
    public class RespostaCSV: Resposta
    {
        public Resposta Proxima { get; private set; }

        public RespostaCSV(Resposta proxima)
        {
            this.Proxima = proxima;
        }

        public void Resposta(Formato formato, Conta conta)
        {
            if(Formato.CSV == formato)
            {
                Console.WriteLine($"{conta.Saldo};{conta.NomeTitular}");
            }
            else
            {
                Proxima.Resposta(formato, conta);
            }
        }
    }
}