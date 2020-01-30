using System;
using System.Data;
using System.Data.SqlClient;


    class UsuarioAplicacao

    {
        public bd bd;
        private void Inserir(Usuario usuario)
        {
            var strQuery = "";
            strQuery += "INSERT INTO usurios(nome, cargo, data)";
            strQuery += string.Format(" VALUES ('{0}', '{1}', '{2}')", usuario.nome, usuario.cargo, usuario.data
                );

            using (bd = new bd())
            {
                bd.ExecutaComando(strQuery);
            }
        }

    public void Alterar(Usuario usuario)
    {
        var strQuery = "";
        strQuery += "UPDATE usuario SET ";
        strQuery += string.Format("Nome = '{0}'", usuario.nome);
        strQuery += string.Format("Cargo = '{0}'", usuario.cargo);
        strQuery += string.Format("Data = '{0}'", usuario.data);
        strQuery += string.Format("WHERE Id = '{0} ", usuario.Id);

        using (bd = new bd())
        {
            bd.ExecutaComando(strQuery);
        }

    }

    public void Salvar(Usuario usuario)
    {
        if(usuario.Id > 0)
        {
            Alterar(usuario);
        }
        else
        {
            Inserir(usuario);
        }

    }
}

