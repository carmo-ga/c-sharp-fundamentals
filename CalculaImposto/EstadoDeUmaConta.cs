namespace CalculaImposto
{
    public interface EstadoDeUmaConta
    {
        public void AplicaDescontoExtra(Orcamento orcamento);

        public void Positivo(Conta conta);
        public void Negativo(Conta conta);
    }
}