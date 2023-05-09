namespace DesignPatterns2.Cap3Memento
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string NomeCliente { get; private set; }
        public TipoContrato Tipo { get; private set; }

        public Contrato(DateTime data, string nomeCliente, TipoContrato tipo)
        {
            this.Data = data;
            this.NomeCliente = nomeCliente;
            this.Tipo = tipo;
        }

        public void Avanca()
        {
            if(this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.EmAndamento;
            else if(this.Tipo == TipoContrato.EmAndamento) this.Tipo = TipoContrato.Acertado;
            else if(this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(this.Data, this.NomeCliente, this.Tipo));
        }

        public void Restaura(Estado estado)
        {
            this.Data = estado.Contrato.Data;
            this.NomeCliente = estado.Contrato.NomeCliente;
            this.Tipo = estado.Contrato.Tipo;
        }
    }
}