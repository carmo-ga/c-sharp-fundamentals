namespace DesignPatterns2.Cap6Bridge
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.Write("Enviando mensagem por e-mail ");
            Console.WriteLine(mensagem.Formata());
        }
    }
}