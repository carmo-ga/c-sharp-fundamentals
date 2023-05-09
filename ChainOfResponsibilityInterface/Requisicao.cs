namespace ChainOfResponsibility
{
    public class Requisicao
    {
        public string ExecutaRequisicao(Formato formato, Conta conta)
        {
            RespostaXML rXML = new RespostaXML();
            RespostaCSV rCSV = new RespostaCSV();
            RespostaPorCento rPorCento = new RespostaPorCento();

            rXML.Proxima = rCSV;
            rCSV.Proxima = rPorCento;

            return rXML.Resposta(formato, conta);
        }
    }
}