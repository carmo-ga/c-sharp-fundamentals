namespace CalculaImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------ Strategy
            // Imposto iss = new ISS();
            // Imposto  icms = new ICMS();
            // Imposto iccc = new ICCC();

            // Orcamento orcamento = new Orcamento(2500.0);

            // CalculadorDeImpostos calculo = new CalculadorDeImpostos();

            // calculo.RealizaCalculo(orcamento, iss);
            // calculo.RealizaCalculo(orcamento, icms);
            // calculo.RealizaCalculo(orcamento, iccc);


            // ------------------ Chain of responsibility
            // CalculadorDeDescontos calculaDesconto = new CalculadorDeDescontos();

            // Orcamento orcamento = new Orcamento(500);
            // orcamento.AdicionaItem(new Item("Caneta", 250));
            // orcamento.AdicionaItem(new Item("Lapis", 250));
            // // orcamento.AdicionaItem(new Item("Borracha", 200));
            // // orcamento.AdicionaItem(new Item("Apontador", 350));
            // // orcamento.AdicionaItem(new Item("Estojo", 200));
            // orcamento.AdicionaItem(new Item("Mochila", 500));
            
            // double desconto = calculaDesconto.Calcula(orcamento);
            // Console.WriteLine(desconto);

            // ------------------ Template Method
            // Orcamento orcamento = new Orcamento(200);

            // Item item1 = new Item("Teclado", 200);
            // Item item2 = new Item("Mouse", 120);
            // Item item3 = new Item("Giz", 220);

            // orcamento.AdicionaItem(item1);
            // orcamento.AdicionaItem(item2);
            // orcamento.AdicionaItem(item3);

            // TemplateDeImpostoCondicional imposto1 = new ICPP();
            // TemplateDeImpostoCondicional imposto2 = new IKCV();

            // double valorTaxa1 = imposto1.Calcula(orcamento);
            // double valorTaxa2 = imposto2.Calcula(orcamento);
            // Console.WriteLine(valorTaxa1);
            // Console.WriteLine(valorTaxa2);

            // ------------------ Decorator
            // O padrão Decorator pode ser aplicado a um objeto que tem diversas responsabilidades.
            // Em vez de criar uma classe com diversos comportamentos, é possível criar classes com poucos comportamentos
            // e fazer composições entre elas, resultando em um corportamento mais comlexo.

            // Imposto impostoComplexo = new ImpostoMuitoAlto(new ICPP(new IKCV(new ISS())));

            // Orcamento orcamento = new Orcamento(500);
            // double valor = impostoComplexo.Calcula(orcamento);
            // Console.WriteLine(valor);


            // ------------------ State
            // quando um objeto tem vários comportamentos de acordo com o estado que ele se encontra
            // comportamentos dessa classe também variam de acordo com o estado do objeto
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);
            reforma.AplicaDescontoExtra();
            reforma.Finaliza();
            // reforma.AplicaDescontoExtra();

            // ------------------ Builder
            // Para objeto complexo de ser criado, que possui diversos atributos, 
            // ou uma lógica de criação complicada, podemos esconder tudo isso em um Builder.

            // IList<ItemDaNota> itens = new List<ItemDaNota>();

            // double valorTotal = 0;
            // foreach (ItemDaNota item in itens)
            // {
            //     valorTotal += item.Valor;
            // }

            // double impostos = valorTotal * 0.05;

            // NotaFiscal nf = new NotaFiscal("5454", "45545", DateTime.Now, 45454, 545454, itens, "45454");

            // ItemDaNotaBuilder itemA = new ItemDaNotaBuilder();
            // itemA
            //     .ComDescricao("Item 1")
            //     .ComValor(300.0);
            // ItemDaNota item1 = itemA.Constroi();

            // ItemDaNotaBuilder itemB = new ItemDaNotaBuilder();
            // itemB
            //     .ComDescricao("Item 2")
            //     .ComValor(100.0);
            // ItemDaNota item2 = itemB.Constroi();


            // NotaFiscalBuilder criador = new NotaFiscalBuilder();
            // criador
            //     .ParaEmpresa("Empresa A")
            //     .ComCnpj("54.542.454/0001-45")
            //     .Com(item1)
            //     .Com(item2)
            //     .ComObservacoes("Observação aqui");

            // ------------------ Observer
            // Quando o acoplamento da classe está crescendo, ou quando temos diversas ações diferentes a serem executadas após um determinado processo
            // Quando temos uma classe que precisa ser notificada sobre alguma coisa e um notificador que, assim que executar uma ação, precisa notificar todos que estão na lista sobre o evento ocorrido. Esse padrão possibilita que o código execute diferentes ações após determinado evento e ajuda a desacoplar o código.
            // criador.AdicionaAcao(new EnviadorDeEmail());
            // criador.AdicionaAcao(new NotaFiscalDao());
            // criador.AdicionaAcao(new EnviadorDeSms());
            // criador.AdicionaAcao(new Multiplicador(4));

            // NotaFiscal nf = criador.Constroi();

            // Console.WriteLine(nf.ValorBruto);
            // Console.WriteLine(nf.Impostos);
            // Console.WriteLine(nf.DataDeEmissao);
            // Console.WriteLine(nf.Observacoes);
            Console.ReadKey();
        }
    }
}

// Objeto que faz muita coisa, classe pequenas que podem ser juntadas os comportamentos resultando em um corportamento complexo
// diferentes combinações de impostos sem precisarmos criar classes novas

// Builder: Objeto com alta complexidade para ser criado, com muitos parâmetros, facilida o proceso de criação de uma classe