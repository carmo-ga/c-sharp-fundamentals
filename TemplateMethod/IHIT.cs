namespace TemplateMethod
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return temDoisItensComMesmoNomeNo(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count());
        }

        private bool temDoisItensComMesmoNomeNo(Orcamento orcamento)
        {
            IList<String> noOrcamento = new List<String>();

            foreach(Item item in orcamento.Itens) 
            {
                if(noOrcamento.Contains(item.Nome))
                {
                    return true;
                }
                else
                {
                    noOrcamento.Add(item.getNome);
                }
            }
            return false;
        }
    }
}