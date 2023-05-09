namespace ChainOfResponsibility
{
    public class Requisicao
    {
        public void ExecutaRequisicao(Formato formato, Conta conta)
        {
            Resposta resultado = new RespostaXML(
                new RespostaCSV(
                    new RespostaPorCento(
                    )
                )
            );

            resultado.Resposta(formato, conta);
        }
    }
}