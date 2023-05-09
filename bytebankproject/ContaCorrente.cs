using bytebank;
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if(value <= 0)
                {
                    return;
                }
                
                _agencia = value;
            }
        }

        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("O argumento agência deve ser maior que 0.", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("O argumento número deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                ContadorSaquesNaoPermitidos++;
                throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));
            }
            if(_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo insuficiente para saque no valor de R$ " + valor);
            }

            _saldo -= valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            // if(saldo < valor)
            // {
            //     throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            // }
            // if(valor <= 0)
            // {
            //     throw new ArgumentException("Valor inválido para transferência.", nameof(valor));
            // }
            // Sacar(valor);
            // contaDestino.Depositar(valor);     

            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Transferência não realizada.", ex);
            }


          
            //Sacar(valor);
            contaDestino.Depositar(valor);
            return true;
        }

        // ----refeito

        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numero_agencia;
        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if(value <= 0)
                {
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_agencia { get; set; }
        private double saldo;


        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        // Construtor explícito
        // public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        // {
        //     Titular = titular;
        //     Nome_agencia = nome_agencia;
        //     Numero_agencia = numero_agencia;
        //     Conta = conta;
        // }
    }
}