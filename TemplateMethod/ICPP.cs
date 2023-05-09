namespace TemplateMethod
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
// Classes cujos algoritmos são semelhantes, representa o algotimo de modo abstrato e as implemtações concretas as variações do altirtmo

// se o alrotimo mudar, basta mudar o template

// O uso do padrão evitou a repetição de código, e ainda facilitou a implementação das diferentes variações do algoritmo.