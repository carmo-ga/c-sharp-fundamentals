namespace DesignPatterns2.Cap6Bridge
{
    public class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.Write("Enviando mensagem por SMS ");
            Console.WriteLine(mensagem.Formata());
        }
    }
}