namespace CalculaImposto
{
    public class Conta
    {
        public EstadoDeUmaConta EstadoAtual { get; set; }

        public double Valor { get; set; }
        
        public Conta(double valor)
        {
            this.Valor = valor;
            this.EstadoAtual = new EmAprovacao();
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}