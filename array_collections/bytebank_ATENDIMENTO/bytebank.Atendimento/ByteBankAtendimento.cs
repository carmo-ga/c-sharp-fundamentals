using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;

namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
    internal class ByteBankAtendimento
    {
        private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
        {
            new ContaCorrente(874){Conta = "4545457-A", Saldo = 100, Titular = new Cliente{Cpf = "999999", Nome = "Henrique"}},
            new ContaCorrente(154){Conta = "5586548-B", Saldo = 200, Titular = new Cliente{Cpf = "888888", Nome = "Pedro"}},
            new ContaCorrente(154){Conta = "5681485-Z", Saldo = 30, Titular = new Cliente{Cpf = "666666", Nome = "Joana"}},
            new ContaCorrente(914){Conta = "6658149-C", Saldo = 300, Titular = new Cliente{Cpf = "777777", Nome = "Luiz"}}
        };

        public void AtendimentoCliente()
        {
            try
            {
                char opcao = '0';
                while(opcao != '6')
                {
                    Console.Clear();
                    Console.WriteLine("============================================");
                    Console.WriteLine("=====            Atendimento           =====");
                    Console.WriteLine("============================================");
                    Console.WriteLine("=====     1 - Cadastrar Conta          =====");
                    Console.WriteLine("=====     2 - Listar Contas            =====");
                    Console.WriteLine("=====     3 - Remover Conta            =====");
                    Console.WriteLine("=====     4 - Ordenar Conta            =====");
                    Console.WriteLine("=====     5 - Pesquisar Contas         =====");
                    Console.WriteLine("=====     6 - Sair do Sistema Conta    =====");
                    Console.WriteLine("============================================");
                    Console.WriteLine("\n");
                    Console.WriteLine("Digite a opção desejada: ");

                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception excecao)
                    {
                        
                        throw new ByteBankException(excecao.Message);
                    }
                    
                    switch(opcao)
                    {
                        case '1':
                            CadastrarConta();
                            break;
                        case '2':
                            ListarContas();
                            break;
                        case '3':
                            RemoverConta();
                            break;
                        case '4':
                            OrdenarContas();
                            break;
                        case '5':
                            PesquisarConta();
                            break;
                        case '6':
                            EncerrarAplicacao();
                            break;
                        default: Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
            }
            catch(ByteBankException excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("Aplicação encerrada.");
        }

        private void PesquisarConta()
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("=======         PESQUISAR CONTAS         =======");
            Console.WriteLine("================================================");
            Console.WriteLine("\n");
            Console.Write("Deseja pesquisar por (1)NÚMERO DA CONTA ou (2)CPF DO TITULAR ou (3)NÚMERO DA AGÊNCIA?");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.Write("Informe o número da conta: ");
                        string _numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.Write("Informe o CPF do titular: ");
                        string _cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Write("Informe o número da agência: ");
                        int _numeroAgencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);

                        ExibirListaDeContas(contasPorAgencia);

                        
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opção inválida.");
                        break;
                    }
            };
        }

        private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if(contasPorAgencia == null)
            {
                Console.WriteLine("A consulta não retornou dados.");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
        {
            var consulta = (
                from conta in _listaDeContas
                where conta.Numero_agencia == numeroAgencia
                select conta).ToList();
            return consulta;
        }

        private ContaCorrente ConsultaPorCPFTitular(string? cpf)
        {
            // ContaCorrente conta = null;
            // for(int i = 0; i < _listaDeContas.Count; i++)
            // {
            //     if(_listaDeContas[i].Titular.Cpf.Equals(cpf))
            //     {
            //         conta = _listaDeContas[i];
            //     }
            // }
            // return conta;

            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
        }

        private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
        {
            // ContaCorrente conta = null;
            // for(int i = 0; i < _listaDeContas.Count; i++)
            // {
            //     if(_listaDeContas[i].Conta.Equals(numeroConta))
            //     {
            //         conta = _listaDeContas[i];
            //     }
            // }
            // return conta;

            return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
        }

        private void OrdenarContas()
        {
            _listaDeContas.Sort();
            Console.WriteLine("Lista de contas ordenadas.");
            Console.ReadKey();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("=======         REMOVER CONTAS           =======");
            Console.WriteLine("================================================");
            Console.WriteLine("\n");
            Console.Write("Informe o número da conta: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;

            foreach(var item in _listaDeContas)
            {
                if(item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }
            }
            if(conta != null)
            {
                _listaDeContas.Remove(conta);
                Console.WriteLine("Conta removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Conta para remoção não encontrada.");
            }
            Console.ReadKey();
        }

        private void ListarContas()
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("=======         LISTA DE CONTAS          =======");
            Console.WriteLine("================================================");
            Console.WriteLine("\n");

            if(_listaDeContas.Count <= 0)
            {
                Console.WriteLine("Não há contas cadastradas.");
                Console.ReadKey();
                return;
            }

            foreach(ContaCorrente item in _listaDeContas)
            {
                // Console.WriteLine("====   Dados da Conta   ====");
                // Console.WriteLine($"Número da Conta: {item.Conta}");
                // Console.WriteLine($"Saldo da Conta: {item.Saldo}");
                // Console.WriteLine($"Titular da Conta: {item.Titular.Nome}");
                // Console.WriteLine($"CPF do Titular: {item.Titular.Cpf}");
                // Console.WriteLine($"Profissão do Titular: {item.Titular.Profissao}");
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ");
                Console.WriteLine("\n");
                Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("=======        CADASTRO DE CONTAS        =======");
            Console.WriteLine("================================================");
            Console.WriteLine("\n");
            Console.WriteLine("=======    Informe os dados da conta     =======");

            Console.Write("Número da agência: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia);
            Console.WriteLine($"Número da nova conta: {conta.Conta}");

            Console.Write("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.Write("Informe o CPF do titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.Write("Informe a profissão do titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            _listaDeContas.Add(conta);

            Console.WriteLine("Conta cadastrada com sucesso!");
            Console.ReadKey();
        }

        // Generic<int> teste1 = new Generic<int>();
        // teste1.MostrarMensagem(10);

        // Generic<string> teste2 = new Generic<string>();
        // teste2.MostrarMensagem("Olá, mundo!");

        // public class Generic<T>
        // {
        //     public void MostrarMensagem(T t)
        //     {
        //         Console.WriteLine($"Exibindo {t}");
        //     }
        // }

        // List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
        // {
        //     new ContaCorrente(874, "4545457-A"){Saldo = 100},
        //     new ContaCorrente(874, "5586548-B"){Saldo = 200},
        //     new ContaCorrente(874, "6658149-C"){Saldo = 300}
        // };

        // List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
        // {
        //     new ContaCorrente(874, "4545457-E"){Saldo = 100},
        //     new ContaCorrente(874, "5586548-F"){Saldo = 200},
        //     new ContaCorrente(874, "6658149-G"){Saldo = 300}
        // };

        // _listaDeContas2.AddRange(_listaDeContas3);
        // _listaDeContas2.Reverse();
        // for(int i = 0; i < _listaDeContas2.Count; i++)
        // {
        //     Console.WriteLine($"Indice[{i}] - Conta [{_listaDeContas2[i].Conta}]");
        // }

        // var range = _listaDeContas3.GetRange(1, 2);
        // for(int i = 0; i < range.Count; i++)
        // {
        //     Console.WriteLine($"Indice[{i}] - Conta [{range[i].Conta}]");
        // }

        // _listaDeContas3.Clear();
        // for(int i = 0; i < _listaDeContas3.Count; i++)
        // {
        //     Console.WriteLine($"Indice[{i}] - Conta [{range[i].Conta}]");
        // }
    }
}