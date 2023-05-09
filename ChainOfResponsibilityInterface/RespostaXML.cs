namespace ChainOfResponsibility
{
    public class RespostaXML : Resposta
    {
        public Resposta Proxima { get; set; }
        public string Resposta(Formato formato, Conta conta)
        {
            if(formato == Formato.XML)
            {
                return $"<conta><saldo>{conta.Saldo}</saldo><titular>{conta.NomeTitular}></titular></conta>";
            }
            else
            {
                return Proxima.Resposta(formato, conta);
            }
        }
    }
}