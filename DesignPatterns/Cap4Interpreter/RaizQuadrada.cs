using DesignPatterns2.Cap5Visitor;

namespace DesignPatterns2.Cap4Interpreter
{
    public class RaizQuadrada : IExpression
    {
        private IExpression radicando;

        public RaizQuadrada(IExpression radicando)
        {
            this.radicando = radicando;
        }

        public int Avalia()
        {
            // double valorRadicando = radicando.Avalia();
            // return Convert.ToInt32(Math.Sqrt(valorRadicando));
            return (int) Math.Sqrt(radicando.Avalia());
        }

        public void Aceita(IVisitor impressora)
        {
            
        }

        public void ImprimePre(IVisitorPreFixa impressoraPre)
        {

        }
    }
}