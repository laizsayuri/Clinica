using MySql.Data.MySqlClient;

namespace Clinica
{
    internal class BancoDeDados
    {
        static string conexao = "server=localhost; port=3306; database=clinica2; uid=auladb; password=password";

        public MySqlConnection conectar()
        {
            MySqlConnection connection = new MySqlConnection(conexao);
            connection.Open();
            return connection;
        }
    }
}
