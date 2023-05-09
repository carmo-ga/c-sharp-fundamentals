
namespace DesignPatterns2.Cap2Flyweight
{
    public class Piano
    {
        public void Play(IList<INota> musica)
        {
            foreach(var nota in musica)
            {
                Console.Beep(nota.Frequencia, 500);
            }
        }
    }
}