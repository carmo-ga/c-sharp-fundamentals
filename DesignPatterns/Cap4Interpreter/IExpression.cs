using DesignPatterns2.Cap5Visitor;

namespace DesignPatterns2.Cap4Interpreter
{
    public interface IExpression
    {
        int Avalia();
        void Aceita(IVisitor impressora);

        void ImprimePre(IVisitorPreFixa impressoraPre);
    }
}