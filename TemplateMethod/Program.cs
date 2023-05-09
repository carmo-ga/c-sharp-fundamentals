namespace TemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(200);

            Item item1 = new Item("Teclado", 200);
            Item item2 = new Item("Mouse", 120);
            Item item3 = new Item("Giz", 220);

            orcamento.AdicionaItem(item1);
            orcamento.AdicionaItem(item2);
            orcamento.AdicionaItem(item3);

            TemplateDeImpostoCondicional imposto1 = new ICPP();
            TemplateDeImpostoCondicional imposto2 = new IKCV();
            TemplateDeImpostoCondicional imposto3 = new IHIT();

            double valorTaxa1 = imposto1.Calcula(orcamento);
            double valorTaxa2 = imposto2.Calcula(orcamento);
            double valorTaxa3 = imposto3.Calcula(orcamento);
            Console.WriteLine(valorTaxa1);
            Console.WriteLine(valorTaxa2);
            Console.WriteLine(valorTaxa3);
        }
    }
}