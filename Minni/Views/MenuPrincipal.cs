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
using ComponentFactory.Krypton.Toolkit;
namespace Minni.Views
{
    public partial class MenuPrincipal : KryptonForm
    {
        Usuario usuario = new Usuario();
        public MenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            lblUsername.Text = "Olá " +usuario.Nome + usuario.Sobrenome + "!";
            this.usuario = usuario;
            AtualizarDgv();
            
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obter o numero da linha selecionada 
            int LinhaSelecionada = dgvEventos.CurrentCell.RowIndex;
            //Obter toda linha selecionada: 
            var dadosLinha = dgvEventos.Rows[LinhaSelecionada];

            lblNomeEvento.Text = dadosLinha.Cells[0].Value.ToString();
            lblDetalhes.Text = "";
            lblResponsavel.Text = usuario.Nome;
            //Mudar cor de fundo do groupbox de acordo com o grau de importancia do evento! 
            grbEventoSelec.BackColor = Color.Green;
        }


      /*  private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            

            //Popular os campos do editar: 
            txbNomeEdi.Text = dadosLinha.Cells[1].Value.ToString();
            txbPrecoEdi.Text = dadosLinha.Cells[2].Value.ToString();


            //Popular o remover: 
            lblRemover.Text = dadosLinha.Cells[0].Value.ToString() + " - " + dadosLinha.Cells[1].Value.ToString();

            //Salvar o id na variavel global 
            idSelecionado = (int)dadosLinha.Cells[0].Value;
        }

        
        */





        private void btnSair_Click(object sender, EventArgs e)
        {
            //Botão sair 
            Close();
        }

        public void AtualizarDgv()
        {
            //Carregar os dados do banco no dgv:
            dgvEventos.DataSource = Database.UsuarioDAO.ListarEventos(usuario.Id);
        }

        private void lblUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
