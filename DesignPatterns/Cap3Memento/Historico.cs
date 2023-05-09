namespace DesignPatterns2.Cap3Memento
{
    public class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }

        public Estado GetEstado(int indice)
        {
            return Estados[indice];
        }
    }
}