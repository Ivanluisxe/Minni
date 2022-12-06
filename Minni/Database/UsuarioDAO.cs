using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaMinni;

namespace Minni.Database
{

    public static class UsuarioDAO
    {
        public static DataTable Logar(Usuario u)
        {
            string comando = "SELECT id, nome, sobrenome, username, senha" +
                    " FROM usuarios WHERE username = @username and senha = @senha ";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            //Substituir os "coringas":
            cmd.Parameters.AddWithValue("@username", u.Username);
            //Obter o hash da senha:
            string hashsenha = EasyEncryption.MD5.ComputeMD5Hash(u.Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);

            cmd.Prepare();

            //Declarar tabela que irá receber o resultado: 
            DataTable tabela = new DataTable();
            //preencher a tabela com o resultado da consulta 
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);

            return tabela;
        }
        public static DataTable ListarTudo()
        {
            string comando = "SELECT id, nome, sobrenome, username FROM usuarios ";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Prepare();

            //Declarar tabela que irá receber o resultado: 
            DataTable tabela = new DataTable();
            //preencher a tabela com o resultado da consulta 
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);

            return tabela;
        }

        public static bool Cadastrar(Usuario u)
        {
            string comando = "INSERT INTO usuarios (nome, sobrenome, username, senha) " +
                "VALUES (@nome, @sobrenome, @username, @senha)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", u.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", u.Sobrenome);
            cmd.Parameters.AddWithValue("@username", u.Username);
            //Tirar hash da senha; 
            string senhaHash = EasyEncryption.SHA.ComputeSHA256Hash(u.Senha);
            cmd.Parameters.AddWithValue("@senha", senhaHash);

            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }

        }
        public static int Remover(int id)
        {
            //WHERE
            string comando = "DELETE FROM usuarios WHERE id = @id ";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Parameters.AddWithValue("@id", id);

            cmd.Prepare();

            try
            {
                int linhasremovidas = cmd.ExecuteNonQuery();
                conexaoBD.Desconectar(con);
                return linhasremovidas;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                //Em caso de erro devolver -1 
                return -1;
            }
        }

        public static DataTable ListarEventos(int id)
        {


            string comando = "SELECT nome_evento AS 'Evento', Importancia  FROM eventos_abertos WHERE privado = 0 OR id_resp_registro = @id ORDER BY id_importancia  ";



            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            cmd.Prepare();
            cmd.Parameters.AddWithValue("@id", id);

            //Declarar tabela que irá receber o resultado: 

            DataTable tabela = new DataTable();
            //preencher a tabela com o resultado da consulta 
            tabela.Load(cmd.ExecuteReader());

            conexaoBD.Desconectar(con);

            return tabela;
        }

        public static bool Editar(Usuario u)
        {

            string comando = "UPDATE usuarios SET nome = @nome, sobrenome = @sobrenome, username = @username, senha = @senha WHERE id = @id";
            //Caso o usuario não altere a senha 
            if (u.Senha == "")
            {
                comando = "UPDATE usuarios SET nome = @nome, sobrenome = @sobrenome, username = @username WHERE id = @id";
            }
            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", u.Id);
            cmd.Parameters.AddWithValue("@nome", u.Nome);
            cmd.Parameters.AddWithValue("@sobrenome", u.Sobrenome);
            cmd.Parameters.AddWithValue("username", u.Username);

            if (u.Senha != "")
            {
                //Tirar hash da senha; 
                string senhaHash = EasyEncryption.MD5.ComputeMD5Hash(u.Senha);
                cmd.Parameters.AddWithValue("@senha", senhaHash);
            }


            cmd.Prepare();

            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }


    }
}
