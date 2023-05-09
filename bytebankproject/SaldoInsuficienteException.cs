using System;

namespace bytebank
{
    public class SaldoInsuficienteException : Exception
    {

        // Construtor sem parâmetros
        public SaldoInsuficienteException() : base() {}

        // Construtor para definir uma propriedade de mensagem
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        // Construtor que define uma propriedade de mensagem e InnerException
        public SaldoInsuficienteException(string mensagem, Exception excecao) : base(mensagem, excecao)
        {

        }

        // Construtor para serializar a exceção
        protected SaldoInsuficienteException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {

        }
    }
}