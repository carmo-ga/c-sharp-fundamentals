namespace ChainOfResponsibility
{
    public class RespostaXML : Resposta
    {
        public Resposta Proxima { get; private set; }

        public RespostaXML(Resposta proxima)
        {
            this.Proxima = proxima;
        }
        
        public void Resposta(Formato formato, Conta conta)
        {
            if(Formato.XML == formato)
            {
                Console.WriteLine($"<conta><saldo>{conta.Saldo}</saldo><titular>{conta.NomeTitular}></titular></conta>");
            }
            else
            {
                Proxima.Resposta(formato, conta);
            }
        }
    }
}