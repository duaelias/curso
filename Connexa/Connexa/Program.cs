using System;
using System.Data.SqlClient;

namespace ExemploDB
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            var bd = new bd();
            var usuario = new Usuario();
            var usuarioAplicacao = new UsuarioAplicacao();
            

            
            SqlConnection conexao = new SqlConnection (@"Server=localhost;Initial Catalog=ExemploBD;Persist Security Info=False;User ID=sa;Password=Poder6645@; MultipleActiveResultSets=True");
            
            
                //Abrindo a conexão
                conexao.Open();


                //string strQueryUpdate = "UPDATE usuario SET nome = 'Fabio' WHERE usuarioId = 1";
                //SqlCommand cmdComandoUpdate = new SqlCommand(strQueryUpdate, conn);
                //cmdComandoUpdate.ExecuteNonQuery();

                //string strQueryDelete = "DELETE FROM usuario WHERE usuarioID = 1";
                //SqlCommand cmdComandoDelete = new SqlCommand(strQueryDelete, conn);
                //cmdComandoDelete.ExecuteNonQuery();

                Console.Write("Digite o nome do usuário:");
                string nome = Console.ReadLine();

                Console.Write("Digite o nome do Cargo:");
                string cargo = Console.ReadLine();

                Console.Write("Digite o nome do Data:");
                string date = Console.ReadLine();

            var Usuario = new Usuario
            {
                nome = nome,
                cargo = cargo,
                data = DateTime.Parse(date)
            };


                Usuario.Id = 4;

                new UsuarioAplicacao().Salvar(usuario);
                

                string strQueryInsert = string.Format("INSERT INTO usuario(nome, cargo, date) VALUES ('{0}', '{1}', '{2}')",nome, cargo, date);
                bd.ExecutaComando(strQueryInsert);

                
                string strQuerySelect = "SELECT * FROM usuario";
                SqlDataReader dados = bd.ExecutaComandoComRetorno(strQuerySelect);

                while (dados.Read())
                {
                    Console.WriteLine("Id:{0}, Nome:{1}, Cargo:{2}, Date:{3}", dados["usuarioId"], dados["nome"], dados["cargo"], dados["date"]);
                }
                
            
        }


    }
}
