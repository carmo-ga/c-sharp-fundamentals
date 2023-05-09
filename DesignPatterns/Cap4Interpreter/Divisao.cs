using DesignPatterns2.Cap5Visitor;

namespace DesignPatterns2.Cap4Interpreter
{
    public class Divisao : IExpression
    {
        private IExpression esquerda;
        private IExpression direita;
        
        public Divisao(IExpression esquerda, IExpression direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda / valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            
        }

        public void ImprimePre(IVisitorPreFixa impressoraPre)
        {

        }
    }
}