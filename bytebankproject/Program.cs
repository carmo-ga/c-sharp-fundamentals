using bytebank;
using bytebank.Titular;
// using ModuloCliente;

//Console.WriteLine("Bem vindo(a) ao seu banco!");

// ContaCorrente conta1 = new ContaCorrente();
// //conta1.titular = "André Silva";
// conta1.conta = "10123-X";
// conta1.numero_agencia = 23;
// conta1.nome_agencia = "Agência Central";
// conta1.saldo = 100;

// ContaCorrente conta2 = new ContaCorrente();
// //conta2.titular = "Amanda Silva";
// conta2.conta = "111999-X";
// conta2.numero_agencia = 58;
// conta2.nome_agencia = "Agência Central";
// conta2.saldo = 100;

// Console.WriteLine($"Titular: {conta2.titular}");
// Console.WriteLine($"Conta: {conta2.conta}");
// Console.WriteLine($"Número Agência: {conta2.numero_agencia}");
// Console.WriteLine($"Nome da Agência: {conta2.nome_agencia}");
// Console.WriteLine($"Saldo: {conta2.saldo}");

// Console.WriteLine($"Saldo: {conta2.saldo}");
// conta2.Sacar(-50);
// Console.WriteLine($"Saldo pós-saque: {conta2.saldo}");

// conta2.Depositar(100);
// Console.WriteLine($"Saldo pós-depósito: {conta2.saldo}");

// bool transferencia = conta1.Transferir(50, conta2);
// Console.WriteLine($"Transferência realizada com sucesso? {transferencia}");
// Console.WriteLine($"Saldo pós-transferência: {conta1.saldo}");
// Console.WriteLine($"Saldo pós-transferência: {conta2.saldo}");

// Cliente cliente = new Cliente();
// cliente.nome = "André Silva";
// cliente.cpf = "15248624822";
// cliente.profissao = "Programador";

// ContaCorrente conta3 = new ContaCorrente();
// conta3.titular = new Cliente();
// conta3.titular.nome = "André Silva";
// conta3.titular.cpf = "15248624822";
// conta3.titular.profissao = "Programador";
// conta3.conta = "2513552-X";
// conta3.numero_agencia = 35;
// conta3.nome_agencia = "Agência Central";

// Console.WriteLine($"Nome Cliente: {conta3.titular.nome}");
// Console.WriteLine($"CPF Cliente: {conta3.titular.cpf}");
// Console.WriteLine($"Profissão Cliente: {conta3.titular.profissao}");

// Cliente sarah = new Cliente();
// sarah.Nome = "Sarah Silva";

// ContaCorrente conta4 = new ContaCorrente(256, "465866-X");
// conta4.Saldo = 1500;
// conta4.Titular = sarah;

// Console.WriteLine($"Nome: {conta4.Titular.Nome}");
// Console.WriteLine($"Saldo: {conta4.Saldo}");
// Console.WriteLine($"Num Age: {conta4.Numero_agencia}");
// Console.WriteLine($"Cc: {conta4.Conta}");

// ContaCorrente conta5 = new ContaCorrente(456, "454544-X");
// ContaCorrente conta6 = new ContaCorrente(585, "687485-X");
// Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

// ------------- Parte 2 - Exceções, camadas

// 1) A ordem das cláusulas importa;

// 2) As exceções mais específicas devem ser capturadas antes das menos específicas;

// 3) Terá um erro de compilação se ordenar os blocos catch de forma que um bloco posterior nunca possa ser alcançado.

// Todas as exceções no .NET derivam do tipo Exception e é nela onde as propriedades Message e StackTrace são definidas.


namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Object
            // Cliente cliente = new Cliente();
            // cliente.Nome = "André";
            // cliente.Cpf = "456.789.456-45";
            // cliente.Email = "andre@email.com";
            // cliente.Idade = 23;

            // Console.WriteLine(cliente.ToString());


            // ContaCorrente conta = new ContaCorrente(45877, 545888);
            // Console.WriteLine(ContaCorrente.TaxaOperacao);

            // ---- Divisão
            // try
            // {
            //     Metodo();
            // }
            // catch(DivideByZeroException)
            // {
            //     Console.WriteLine("Não é possível dividir por 0.");
            // }
            // catch(NullReferenceException)
            // {
            //     Console.WriteLine("Referência nula.");
            // }

            // Exceções ContaCorrente - Sacar/Depositar/Transferir
            try
            {
                ContaCorrente conta = new ContaCorrente(441, 4845);
                ContaCorrente conta2 = new ContaCorrente(451, 4574);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                conta.Transferir(500, conta2);
                Console.WriteLine(conta.Saldo);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            catch(OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            
            //CarregarContas(); // -- Leitura de arquivo
        }

        // Leitura de arquivo
        // private static void CarregarContas()
        // {
        //     LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
        //     try
        //     {
        //         leitor.LerProximaLinha();
        //         leitor.LerProximaLinha();
        //     }
        //     catch(FileNotFoundException e)
        //     {
        //         Console.WriteLine("Arquivo não encontrado!");
        //     }
        //     catch(IOException e)
        //     {
        //         Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
        //     }
        //     finally
        //     {
        //         leitor.Fechar();
        //     }
        // }

        // Métodos para divisão
        // private static void Metodo()
        // {
        //     TestaDivisao(10);
        // }

        // private static void TestaDivisao(int divisor)
        // {
        //     int resultado = Dividir(10, divisor);
        //     Console.WriteLine("o resultado da divisão de 10 por " + divisor + " é " + resultado);
            
        // }

        // private static int Dividir(int numerador, int denominador)
        // {
        //     try
        //     {
        //         return numerador / denominador;
        //     }
        //     catch
        //     {
        //         Console.WriteLine("Exceção com o numerador " + numerador + " e denominador " + denominador);
        //         throw;
        //     }
        // }
    }
}