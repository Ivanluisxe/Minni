namespace Minni.Views
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.dgvEventos = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btnSair = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTitulo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUsername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblInfosPost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblInfoEventos = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.chbEventoConcluido = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.grbEventoSelec = new System.Windows.Forms.GroupBox();
            this.lblResponsavel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDetalhes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblNomeEvento = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dgvAux = new System.Windows.Forms.DataGridView();
            this.txbNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbDescricao = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbxImportancia = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.chbPrivacidade = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblNomeCad = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDescriCad = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnCadastrarEvento = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grbNovoEvento = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.grbEventoSelec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbNovoEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbNovoEvento.Panel)).BeginInit();
            this.grbNovoEvento.Panel.SuspendLayout();
            this.grbNovoEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 16;
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToResizeColumns = false;
            this.dgvEventos.AllowUserToResizeRows = false;
            this.dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEventos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Location = new System.Drawing.Point(12, 91);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(368, 288);
            this.dgvEventos.TabIndex = 0;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(780, 542);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(42, 25);
            this.btnSair.TabIndex = 2;
            this.btnSair.Values.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 29);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Values.Text = "Minni Eventos ";
            this.lblTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTitulo_Paint);
            // 
            // lblUsername
            // 
            this.lblUsername.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblUsername.Location = new System.Drawing.Point(375, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 29);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Values.Text = "____________";
            this.lblUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.lblUsername_Paint);
            // 
            // lblInfosPost
            // 
            this.lblInfosPost.Location = new System.Drawing.Point(400, 70);
            this.lblInfosPost.Name = "lblInfosPost";
            this.lblInfosPost.Size = new System.Drawing.Size(187, 20);
            this.lblInfosPost.TabIndex = 5;
            this.lblInfosPost.Values.Text = "Detalhes do evento selecionado:";
            // 
            // lblInfoEventos
            // 
            this.lblInfoEventos.Location = new System.Drawing.Point(12, 70);
            this.lblInfoEventos.Name = "lblInfoEventos";
            this.lblInfoEventos.Size = new System.Drawing.Size(93, 20);
            this.lblInfoEventos.TabIndex = 6;
            this.lblInfoEventos.Values.Text = "Todos eventos:";
            // 
            // chbEventoConcluido
            // 
            this.chbEventoConcluido.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.chbEventoConcluido.Location = new System.Drawing.Point(254, 414);
            this.chbEventoConcluido.Name = "chbEventoConcluido";
            this.chbEventoConcluido.Size = new System.Drawing.Size(125, 20);
            this.chbEventoConcluido.TabIndex = 7;
            this.chbEventoConcluido.Values.Text = "Evento Concluído";
            this.chbEventoConcluido.CheckedChanged += new System.EventHandler(this.chbEventoConcluido_CheckedChanged);
            // 
            // grbEventoSelec
            // 
            this.grbEventoSelec.BackColor = System.Drawing.Color.LightSalmon;
            this.grbEventoSelec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbEventoSelec.Controls.Add(this.lblResponsavel);
            this.grbEventoSelec.Controls.Add(this.chbEventoConcluido);
            this.grbEventoSelec.Controls.Add(this.lblDetalhes);
            this.grbEventoSelec.Controls.Add(this.lblNomeEvento);
            this.grbEventoSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbEventoSelec.Location = new System.Drawing.Point(398, 92);
            this.grbEventoSelec.Margin = new System.Windows.Forms.Padding(1);
            this.grbEventoSelec.Name = "grbEventoSelec";
            this.grbEventoSelec.Size = new System.Drawing.Size(379, 441);
            this.grbEventoSelec.TabIndex = 8;
            this.grbEventoSelec.TabStop = false;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel;
            this.lblResponsavel.Location = new System.Drawing.Point(6, 415);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(106, 20);
            this.lblResponsavel.TabIndex = 2;
            this.lblResponsavel.Values.Text = "Evento criado por: ";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblDetalhes.Location = new System.Drawing.Point(6, 89);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(66, 20);
            this.lblDetalhes.TabIndex = 1;
            this.lblDetalhes.Values.Text = "Descrição:";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblNomeEvento.Location = new System.Drawing.Point(6, 19);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(71, 29);
            this.lblNomeEvento.TabIndex = 0;
            this.lblNomeEvento.Values.Text = "Nome:";
            // 
            // dgvAux
            // 
            this.dgvAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAux.Location = new System.Drawing.Point(39, 369);
            this.dgvAux.Name = "dgvAux";
            this.dgvAux.Size = new System.Drawing.Size(307, 10);
            this.dgvAux.TabIndex = 9;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(162, 8);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(135, 23);
            this.txbNome.TabIndex = 10;
            // 
            // txbDescricao
            // 
            this.txbDescricao.Location = new System.Drawing.Point(162, 45);
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(135, 23);
            this.txbDescricao.TabIndex = 11;
            // 
            // cbxImportancia
            // 
            this.cbxImportancia.DropDownWidth = 135;
            this.cbxImportancia.Location = new System.Drawing.Point(162, 81);
            this.cbxImportancia.Name = "cbxImportancia";
            this.cbxImportancia.Size = new System.Drawing.Size(135, 21);
            this.cbxImportancia.TabIndex = 13;
            // 
            // chbPrivacidade
            // 
            this.chbPrivacidade.Location = new System.Drawing.Point(80, 118);
            this.chbPrivacidade.Name = "chbPrivacidade";
            this.chbPrivacidade.Size = new System.Drawing.Size(70, 20);
            this.chbPrivacidade.TabIndex = 14;
            this.chbPrivacidade.Values.Text = "Privado? ";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblNomeCad.Location = new System.Drawing.Point(80, 3);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(71, 29);
            this.lblNomeCad.TabIndex = 8;
            this.lblNomeCad.Values.Text = "Nome:";
            // 
            // lblDescriCad
            // 
            this.lblDescriCad.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblDescriCad.Location = new System.Drawing.Point(51, 38);
            this.lblDescriCad.Name = "lblDescriCad";
            this.lblDescriCad.Size = new System.Drawing.Size(101, 29);
            this.lblDescriCad.TabIndex = 15;
            this.lblDescriCad.Values.Text = "Descrição:";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(31, 73);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(123, 29);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "Importancia:";
            // 
            // btnCadastrarEvento
            // 
            this.btnCadastrarEvento.Location = new System.Drawing.Point(162, 115);
            this.btnCadastrarEvento.Name = "btnCadastrarEvento";
            this.btnCadastrarEvento.Size = new System.Drawing.Size(135, 25);
            this.btnCadastrarEvento.TabIndex = 17;
            this.btnCadastrarEvento.Values.Text = "Cadastrar Evento";
            this.btnCadastrarEvento.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // grbNovoEvento
            // 
            this.grbNovoEvento.CaptionEdge = ComponentFactory.Krypton.Toolkit.VisualOrientation.Bottom;
            this.grbNovoEvento.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ToolTip;
            this.grbNovoEvento.Cursor = System.Windows.Forms.Cursors.Default;
            this.grbNovoEvento.Location = new System.Drawing.Point(13, 392);
            this.grbNovoEvento.Name = "grbNovoEvento";
            // 
            // grbNovoEvento.Panel
            // 
            this.grbNovoEvento.Panel.Controls.Add(this.btnCadastrarEvento);
            this.grbNovoEvento.Panel.Controls.Add(this.lblNomeCad);
            this.grbNovoEvento.Panel.Controls.Add(this.txbDescricao);
            this.grbNovoEvento.Panel.Controls.Add(this.kryptonLabel1);
            this.grbNovoEvento.Panel.Controls.Add(this.txbNome);
            this.grbNovoEvento.Panel.Controls.Add(this.cbxImportancia);
            this.grbNovoEvento.Panel.Controls.Add(this.lblDescriCad);
            this.grbNovoEvento.Panel.Controls.Add(this.chbPrivacidade);
            this.grbNovoEvento.Size = new System.Drawing.Size(367, 175);
            this.grbNovoEvento.TabIndex = 10;
            this.grbNovoEvento.Values.Heading = "";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minni.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 579);
            this.Controls.Add(this.grbNovoEvento);
            this.Controls.Add(this.grbEventoSelec);
            this.Controls.Add(this.lblInfoEventos);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.lblInfosPost);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvAux);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.grbEventoSelec.ResumeLayout(false);
            this.grbEventoSelec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImportancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbNovoEvento.Panel)).EndInit();
            this.grbNovoEvento.Panel.ResumeLayout(false);
            this.grbNovoEvento.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbNovoEvento)).EndInit();
            this.grbNovoEvento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEventos;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSair;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitulo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInfosPost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInfoEventos;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chbEventoConcluido;
        private System.Windows.Forms.GroupBox grbEventoSelec;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblResponsavel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDetalhes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNomeEvento;
        private System.Windows.Forms.DataGridView dgvAux;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbDescricao;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbxImportancia;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chbPrivacidade;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNomeCad;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDescriCad;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCadastrarEvento;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grbNovoEvento;
    }
}