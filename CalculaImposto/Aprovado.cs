namespace CalculaImposto
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if(!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
            {
                Console.WriteLine("Desconto já foi aplicado.");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está aprovado.");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está aprovado, não pode ser reprovado agora.");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}