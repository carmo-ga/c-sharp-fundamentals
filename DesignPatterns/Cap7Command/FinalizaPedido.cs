namespace DesignPatterns2.Cap7Command
{
    public class FinalizaPedido : IComando
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            System.Console.WriteLine($"Finalizando pedido do cliente {pedido.Cliente}");
            pedido.Finaliza();
        }
    }
}