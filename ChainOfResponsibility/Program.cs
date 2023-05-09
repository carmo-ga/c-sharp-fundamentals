namespace ChainOfResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(200.0, "Miltom Nascimento");
            Conta conta2 = new Conta(6520.0, "Guilherme Arantes");
            Conta conta3 = new Conta(1000.0, "Tom Jobim");

            Requisicao requisicao = new Requisicao();
            
            requisicao.ExecutaRequisicao(Formato.PORCENTO, conta1);
            requisicao.ExecutaRequisicao(Formato.XML, conta2);
            requisicao.ExecutaRequisicao(Formato.CSV, conta3);
        }
    }
}

// Recebendo o próximo item da corrente através do construtor, sempre que o objeto for instanciado, torna-se obrigatório designar qual o próximo elo. Porém, é retirada a criação da propriedade "Proximo" da interface, ou seja, é preciso lembrar de criar essa propriedade dentro de cada uma das classes para que se cumpra o propósito da corrente.

// O padrão Chain of Responsibility é válido quando temos uma lista de comandos a serem executados de acordo com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado, caso o anterior não satisfaça a condição.
// Possibilita a separação de responsabilidades em classes pequenas e enxutas, e ainda provê uma maneira flexível e desacoplada de juntar esses comportamentos novamente.