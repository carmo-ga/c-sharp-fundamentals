using DesignPatterns2.Cap4Interpreter;

namespace DesignPatterns2.Cap5Visitor
{
    public class ImpressoraVisitorPreFixa : IVisitorPreFixa
    {
        public void ImprimeSomaPreFixa(Soma soma)
        {
            Console.Write("(+ ");
            soma.Esquerda.ImprimePre(this);
            Console.Write(" ");
            soma.Direita.ImprimePre(this);
            Console.Write(")");
        }

        public void ImprimeSubtracaoPreFixa(Subtracao subtracao)
        {
            Console.Write("(- ");
            subtracao.Esquerda.ImprimePre(this);
            Console.Write(" ");
            subtracao.Direita.ImprimePre(this);
            Console.Write(")");
        }

        public void ImprimeNumeroPre(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}