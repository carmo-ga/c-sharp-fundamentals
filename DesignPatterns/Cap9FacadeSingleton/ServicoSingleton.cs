namespace DesignPatterns2.Cap9FacadeSingleton
{
    public class ServicoSingleton
    {
        private static Servico servico = new Servico();

        public Servico Instancia
        {
            get
            {
                return servico;
            }
        }
    }
}