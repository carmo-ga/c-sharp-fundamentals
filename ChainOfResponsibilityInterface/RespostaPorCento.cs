namespace ChainOfResponsibility
{
    public class RespostaPorCento: Resposta
    {
        public Resposta Proxima { get; set; }
        public string Resposta(Formato formato, Conta conta)
        {
            if(formato == Formato.PORCENTO)
            {
                return $"{conta.Saldo} % {conta.NomeTitular}";
            }
            else
            {
                return Proxima.Resposta(formato, conta);
            }
        }
    }
}