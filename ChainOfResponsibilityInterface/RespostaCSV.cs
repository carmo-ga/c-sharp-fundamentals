namespace ChainOfResponsibility
{
    public class RespostaCSV: Resposta
    {
        public Resposta Proxima { get; set; }
        public string Resposta(Formato formato, Conta conta)
        {
            if(formato == Formato.CSV)
            {
                return $"{conta.Saldo};{conta.NomeTitular}";
            }
            else
            {
                return Proxima.Resposta(formato, conta);
            }
        }
    }
}