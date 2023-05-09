namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(200.0, "Miltom Nascimento");
            Conta conta2 = new Conta(6520.0, "Guilherme Arantes");
            Conta conta3 = new Conta(1000.0, "Tom Jobim");

            Requisicao requisicao = new Requisicao();
            //Requisicao requisicao2 = new Requisicao();
            //Requisicao requisicao3 = new Requisicao();
            
            string resposta1 = requisicao.ExecutaRequisicao(Formato.PORCENTO, conta1);
            Console.WriteLine(resposta1);
            string resposta2 = requisicao.ExecutaRequisicao(Formato.XML, conta2);
            Console.WriteLine(resposta2);
            string resposta3 = requisicao.ExecutaRequisicao(Formato.CSV, conta3);
            Console.WriteLine(resposta3);
        }
    }
}