using MySql.Data.MySqlClient;

namespace PawPlace.Conection
{
    public class DBConection
    {
        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection("Data Source=PC_PHCVIEIRA;Initial Catalog=PawPlace;Integrated Security=True;Encrypt=False");
        }
    }
}
