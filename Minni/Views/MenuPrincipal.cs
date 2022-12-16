using System;
using System.Collections;
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
        int idSelecionado = 0;
        Usuario usuario = new Usuario();

        //Procedimentos : 

        public void Listartudo()
        {
            dgvAux.DataSource = Database.UsuarioDAO.ListarTudoEvento(idSelecionado);
        }
        public void AtualizarDgv()
        {
            //Carregar os dados do banco no dgv:
            dgvEventos.DataSource = Database.UsuarioDAO.ListarEventos(usuario.Id);
        }
        

        public MenuPrincipal(Usuario usuario)
        {


            

            InitializeComponent();
            lblUsername.Text = "Olá " +usuario.Nome + usuario.Sobrenome + "!";
            this.usuario = usuario;
            AtualizarDgv();
            chbEventoConcluido.Enabled = false;

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Database.EventoDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter esse objeto para array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cbxImportancia.DataSource = rows;
            //cmbCategoriaEdi.DataSource = rows.Clone();

        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgvEventos.Rows.Count > 0)
            { 
            //Obter o numero da linha selecionada 
            int LinhaSelecionada = dgvEventos.CurrentCell.RowIndex;
            //Obter toda linha selecionada: 
            var dadosLinha = dgvEventos.Rows[LinhaSelecionada];
            //Salvar o id na variavel global 
            idSelecionado = (int)dadosLinha.Cells[0].Value;

            AtualizarDgv();

            Listartudo();

            var dadosAux = dgvAux.Rows[0];            
            try
            { 
            lblNomeEvento.Text = dadosAux.Cells[1].Value.ToString();
            lblDetalhes.Text = dadosAux.Cells[3].Value.ToString();
            lblResponsavel.Text = "Evento criado por: " + dadosAux.Cells[7].Value.ToString();
            chbEventoConcluido.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Não há eventos para mostrar.");
            }


            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Botão sair 
            Close();
        }       

        private void lblUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chbEventoConcluido_CheckedChanged(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Tem certeza que deseja concluir o evento \n" +
                "" + lblNomeEvento.Text + "?", "CUIDADO!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {

                //Se sim, setar a situação do evento para 0 

                if (Database.UsuarioDAO.ConcluirEventos(idSelecionado))
                {
                    MessageBox.Show("Show! Evento concluído com sucesso!");
                                      
                   

                    //Atualizar o dgv. 
                    AtualizarDgv();
                    
                }
                else
                {
                    MessageBox.Show("Erro ao concluir o evento!");

                }
            }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Verificar se os campos estão vazios: 
            if (txbNome.Text.Length > 5 && txbDescricao.Text.Length > 5)
            {
                //Instanciar evento
                Evento ev = new Evento();
                //obter as informações dos campos: 

                ev.Nome = txbNome.Text;                
                ev.Descricao= txbDescricao.Text;
                ev.IdRespRegistro = usuario.Id;
                ev.Privado = chbPrivacidade.Checked;
                ev.Situacao = true;                
                ev.IdImportancia = obterIDdaString(cbxImportancia.Text);

                //Enviar para o banco e verificar se deu certo. 
                if (Database.EventoDAO.Cadastrar(ev))
                {
                    MessageBox.Show("Evento cadastrado com sucesso!");

                    txbNome.Clear();
                    txbDescricao.Clear();

                    //Atualizar o dgv. 
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o evento.");

                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas");
            }


        }
        private int obterIDdaString(string texto)
        {
            /* Ao chamar obterIDdaString("12 - Alimentação")
             * o resultador será 12
             * Show?
             */
            return int.Parse(texto.Split(' ')[0]);
        }
    }
}
