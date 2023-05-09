using DesignPatterns2.Cap1Factory;
using DesignPatterns2.Cap2Flyweight;
using DesignPatterns2.Cap3Memento;
using DesignPatterns2.Cap4Interpreter;
using DesignPatterns2.Cap5Visitor;
using DesignPatterns2.Cap6Bridge;
using DesignPatterns2.Cap7Command;
using DesignPatterns2.Cap8Adapter;
using DesignPatterns2.Cap9FacadeSingleton;
using System.Linq.Expressions;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------- Factory
            // IDbConnection conexao = new ConnectionFactory().GetConnection();

            // IDbCommand comando = conexao.CreateCommand();
            // comando.CommandText = "select * from tabela";

            // ------------- Flyweight
            // Quando muitos objetos precisam compartilhar recurso da máquina.
            // Quando precisamos instanciar diversos vezes uma classe (criar vários objetos iguais).Possibilita que o objeto seja criado apenas uma vez e reutilizado quantas vezes forem necessários dentro da aplicação, fazendo com que os recursos físicos da máquina sejam economizados.
            // Instancia uma classe apenas uma vez e reutiliza essa instância várias vezes.
            // Sempre que temos uma quantidade grande de objetos similares a serem instanciados, uma boa solução é fazer cache dessas instâncias e reutilizá-la. Para isso, a implementação geralmente faz uso de uma fábrica, que controla as instâncias.
            // NotasMusicais notas = new NotasMusicais();

            // IList<INota> music = new List<INota>() {
            //     notas.GetNota("do"),
            //     notas.GetNota("re"),
            //     notas.GetNota("mi"),
            //     notas.GetNota("fa"),
            //     notas.GetNota("fa"),
            //     notas.GetNota("fa"),
            // };

            // Piano piano = new Piano();
            // piano.Play(music);

            // ------------- Memento
            // Salva o estado de um objeto que precisa ser restaurado posteriormente
            // Historico historico = new Historico();

            // Contrato contrato = new Contrato(DateTime.Now, "Maria", TipoContrato.Novo);
            // historico.Adiciona(contrato.SalvaEstado());

            // contrato.Avanca();
            // historico.Adiciona(contrato.SalvaEstado());

            // contrato.Avanca();
            // historico.Adiciona(contrato.SalvaEstado());

            // contrato.Restaura(historico.GetEstado(0));
            // historico.Adiciona(contrato.SalvaEstado());

            // Console.WriteLine(historico.GetEstado(0).Contrato.Tipo);
            // Console.WriteLine(historico.GetEstado(1).Contrato.Tipo);
            // Console.WriteLine(historico.GetEstado(2).Contrato.Tipo);
            // Console.WriteLine(historico.GetEstado(3).Contrato.Tipo);

            // ------------- Interpreter
            // Quando temos expressões que devem ser avaliadas, a transformamos em uma estrutura de dados, e depois fazemos com que a própria árvore se avalie.

            // ((1 + 10) + (20 - 10))
            // IExpression esquerda = new Soma(new Numero(1), new Numero(10));
            // IExpression direita = new Subtracao(new Numero(20), new Numero(10));
            // IExpression soma = new Soma(esquerda, direita);
            // Console.WriteLine(soma.Avalia());

            // ((25 * 4) + 50) / (10 * 2)
            // IExpression esq = new Soma(new Multiplicacao(new Numero(25), new Numero(4)), new Numero(50));
            // IExpression dir = new Multiplicacao(new Numero(10), new Numero(2));
            // IExpression divisao = new Divisao(esq, dir);
            // Console.WriteLine(divisao.Avalia());

            // IExpression rad = new RaizQuadrada(new Numero(9));
            // Console.WriteLine(rad.Avalia());
            
            // API do C#
            // Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            // Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();

            // Console.WriteLine(funcao());

            // ------------- Visitor
            // Quando temos uma árvore, e precisamos navegar nessa árvore de maneira organizada
            // ImpressoraVisitor impressora = new ImpressoraVisitor();
            // soma.Aceita(impressora);

            // Console.WriteLine();

            // ImpressoraVisitorPreFixa impressoraPre = new ImpressoraVisitorPreFixa();
            // soma.ImprimePre(impressoraPre);

            // ------------- Bridge
            // Quando uma hierarquia de classes é responsável por diversas características do sistema, podemos separar as características em diversas hierarquias ligando-as através da composição de classes.
            // IMensagem mensagem = new MensagemCliente("João");
            // IEnviador enviador = new EnviaPorSMS();
            // mensagem.Enviador = enviador;
            // mensagem.Envia();

            // ------------- Command
            // Quando precisamos guardar uma sequência de comandos que serão executados posteriormente
            // FilaDeTrabalho fila = new FilaDeTrabalho();
            // Pedido pedido1 = new Pedido("Marcelo", 100.0);
            // Pedido pedido2 = new Pedido("Miguel", 200.0);
            // fila.Adiciona(new PagaPedido(pedido1));
            // fila.Adiciona(new PagaPedido(pedido2));
            // fila.Adiciona(new FinalizaPedido(pedido1));

            // fila.Processa();

            // ------------- Adapter
            // Utilizar na aplicação atual um código legado ou biblioteca dentro do projeto, isola-se o código dentro de uma classe
            // Cliente cliente = new Cliente();
            // cliente.Nome = "José";
            // cliente.Endereco = "Rua Manaus";
            // cliente.DataDeNascimento = DateTime.Now;

            // String xml = new GeradorDeXml().GeraXml(cliente);
            // Console.WriteLine(xml);

            // ------------- Facade
            // Provê uma interface para os serviços fornecidos por um subsistema complexo (biblioteca, framework). Pode ficar muito complexa.

            //String cpf = "1234";

            // ------------- Singleton
            // É um padrão para criação de projeto que garante que uma classe tenha apenas uma instância, fornecendo um ponto de acesso global a essa instância.
            EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            // Cliente cliente = facade.BuscaCliente(cpf);

            // var fatura = facade.CriaFatura(cliente, 5000.0);
            // facade.GeraCobranca(tipo.Boleto, fatura);
        }
    }
}