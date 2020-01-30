using System;
using System.Data.SqlClient;

namespace ConexaoBD
{
    public class Program
    {

        public static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection(@"data source=localhost ;Integrated Security=SSPI ;Initial Catalog=ExemploDB");
            conexao.Open();
        }
    }
}
