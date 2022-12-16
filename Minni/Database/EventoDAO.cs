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
    internal class EventoDAO
    {


     
            public static DataTable ListarTudo()
            {
                string comando = "SELECT id, nome FROM importancia ";

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
        public static bool Cadastrar(Evento ev)
        {
            string comando = "INSERT INTO eventos (nome_evento, descricao, situacao, id_importancia, id_resp_registro, privado ) " +
                "VALUES (@nome_evento, @descricao, @situacao, @id_importancia, @id_resp_registro, @privado)";

            ConexaoBD conexaoBD = new ConexaoBD();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_evento", ev.Nome);
            cmd.Parameters.AddWithValue("@descricao", ev.Descricao);
            cmd.Parameters.AddWithValue("@situacao", ev.Situacao);
            cmd.Parameters.AddWithValue("@id_importancia", ev.IdImportancia);
            cmd.Parameters.AddWithValue("@id_resp_registro", ev.IdRespRegistro);
            cmd.Parameters.AddWithValue("@privado", ev.Privado);






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
