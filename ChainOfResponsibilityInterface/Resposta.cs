namespace ChainOfResponsibility
{
    public interface Resposta
    {
        Resposta Proxima { get; set; }
        public string Resposta(Formato formato, Conta conta);
    }
}