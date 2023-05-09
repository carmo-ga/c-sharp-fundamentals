using DesignPatterns2.Cap4Interpreter;

namespace DesignPatterns2.Cap5Visitor
{
    public interface IVisitorPreFixa
    {
        void ImprimeNumeroPre(Numero numero);
        void ImprimeSomaPreFixa(Soma soma);
        void ImprimeSubtracaoPreFixa(Subtracao subtracao);
    }
}