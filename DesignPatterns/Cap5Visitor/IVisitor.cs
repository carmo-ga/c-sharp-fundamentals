using DesignPatterns2.Cap4Interpreter;

namespace DesignPatterns2.Cap5Visitor
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
    }
}