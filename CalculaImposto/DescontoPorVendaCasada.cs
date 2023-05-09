namespace CalculaImposto
{
    public class DescontoPorVendaCasada : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            // bool lapis = Existe("Lapis", orcamento);
            // bool caneta = Existe("Caneta", orcamento);

            if(houveVendaCadasaEm(orcamento)) return orcamento.Valor * 0.05;
            else return Proximo.Desconta(orcamento);
        }

        private bool houveVendaCadasaEm(Orcamento orcamento)
        {
            return Existe("Lapis", orcamento) && Existe("Caneta", orcamento);
        }

        private bool Existe(string nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if(item.Nome.Equals(nomeDoItem))
                {
                    return true;
                }
            }
            return false;
        }
    }
}