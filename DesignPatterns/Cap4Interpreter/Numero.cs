using DesignPatterns2.Cap5Visitor;

namespace DesignPatterns2.Cap4Interpreter
{
    public class Numero : IExpression
    {
        public int Valor { get; private set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public int Avalia()
        {
            return this.Valor;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }

        public void ImprimePre(IVisitorPreFixa impressoraPre)
        {
            impressoraPre.ImprimeNumeroPre(this);
        }
    }
}