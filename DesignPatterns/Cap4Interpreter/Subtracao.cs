using DesignPatterns2.Cap5Visitor;

namespace DesignPatterns2.Cap4Interpreter
{
    public class Subtracao : IExpression
    {
        public IExpression Esquerda { get; private set; }
        public IExpression Direita { get; private set; }
        
        public Subtracao(IExpression esquerda, IExpression direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }

        public void ImprimePre(IVisitorPreFixa impressoraFixa)
        {
            impressoraFixa.ImprimeSubtracaoPreFixa(this);
        }
    }
}