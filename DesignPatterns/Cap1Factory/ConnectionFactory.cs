using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2.Cap1Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            // Isola a criação de um objeto cujas configurações são (quase sempre) as mesmas
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
            conexao.Open();
            
            return conexao;
        }
    }
}