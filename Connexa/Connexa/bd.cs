using System;
using System.Data;
using System.Data.SqlClient;



   public class bd : IDisposable
    {
        private readonly SqlConnection conexao;

        public bd()
        {
            conexao = new SqlConnection ("Server=localhost;Initial Catalog=ExemploBD;Persist Security Info=False;User ID=sa;Password=Poder6645@; MultipleActiveResultSets=True");
            conexao.Open();
        }

        public void ExecutaComando(string strQuery)
        {
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = conexao

            };
        
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            var cmdComandoSelect = new SqlCommand(strQuery, conexao);
            return cmdComandoSelect.ExecuteReader();
        }

        public void Dispose()
        {
            if(conexao.State == ConnectionState.Open) { }
            conexao.Close();
        }
    }
