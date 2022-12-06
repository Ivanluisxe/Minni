using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaMinni;

namespace Minni
{
    public partial class login : KryptonForm
    {
        public login()
        {
            InitializeComponent();
                       
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text.Length >= 6 && txbSenha.Text.Length >= 1)
            {
                //Fazer validação
                //Instanciar o usuario 
                Usuario usuario = new Usuario();

                //Atribuir os valores dos campos no usuario:
                usuario.Username = txbUsername.Text;
                usuario.Senha = txbSenha.Text;

                //Consultar os dados no banco e obter o resultado em uma tabela 
                DataTable resultado = Database.UsuarioDAO.Logar(usuario);

                //Verificar se houve resultado na consulta: 
                if (resultado.Rows.Count > 0)
                {
                    //Limpar os campos: 
                    txbUsername.Clear();
                    txbSenha.Clear();

                    //Atribuir os resultados da consulta no objeto usuário:
                    usuario.Nome = resultado.Rows[0]["nome"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];



                    //Ir para o menu principal 
                    Views.MenuPrincipal menuPrincipal = new Views.MenuPrincipal(usuario);
                    //Esconder o form atual 
                    Hide();
                    //Mostrar o menu principal 
                    menuPrincipal.ShowDialog();

                    //Mostrar a tela de login após fechar o menu 
                    Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senhas inválidos!");
                }

            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas e tente novamente!");
            }
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
