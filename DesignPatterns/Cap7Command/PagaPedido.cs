namespace DesignPatterns2.Cap7Command
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine($"Pagando pedido do cliente {pedido.Cliente}");
            pedido.Paga();
        }
    }
}