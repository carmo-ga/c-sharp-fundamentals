namespace CalculaImposto
{
    public class ItemDaNota
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public ItemDaNota(string descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}