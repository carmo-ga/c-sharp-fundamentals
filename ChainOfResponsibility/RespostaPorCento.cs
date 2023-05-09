namespace ChainOfResponsibility
{
    public class RespostaPorCento: Resposta
    {
        private Resposta Proxima { get; set; }

        public RespostaPorCento(Resposta proxima)
        {
            this.Proxima = proxima;
        }

        public RespostaPorCento()
        {
            this.Proxima = null;
        }

        public void Resposta(Formato formato, Conta conta)
        {
            if(Formato.PORCENTO == formato)
            {
                Console.WriteLine($"{conta.Saldo} % {conta.NomeTitular}");
            }
            else if(Proxima != null)
            {
                Proxima.Resposta(formato, conta);
            }
            else
            {
                throw new Exception("Formato inválido.");
            }
        }
    }
}