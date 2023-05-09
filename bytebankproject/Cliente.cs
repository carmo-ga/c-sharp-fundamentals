namespace bytebank.Titular
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }
        public string Profissao { get; set; }
    }
}


// ---- Object
// namespace ModuloCliente
// {
//     public class Cliente
//     {
//         public string Cpf { get; set; }
//         public string Nome { get; set; }
//         public string? Email { get; set; }
//         public int Idade { get; set; }

//         public override string ToString()
//         {
//             return $"Nome: {this.Nome}\n" +
//                    $"Email: {this.Email}\n" +
//                    $"Idade: {this.Idade}\n" +
//                    $"CPF: {this.Cpf}";
//         }
//     }
// }