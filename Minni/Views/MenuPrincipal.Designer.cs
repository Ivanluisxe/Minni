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
            this.btnMenu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnSair = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblTitulo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUsername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblInfosPost = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblInfoEventos = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.grbEventoSelec = new System.Windows.Forms.GroupBox();
            this.lblNomeEvento = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblDetalhes = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblResponsavel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.grbEventoSelec.SuspendLayout();
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
            this.dgvEventos.Location = new System.Drawing.Point(12, 96);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.Size = new System.Drawing.Size(350, 442);
            this.dgvEventos.TabIndex = 0;
            this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(931, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 25);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Values.Text = "Menu";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(931, 537);
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
            this.lblInfosPost.Location = new System.Drawing.Point(398, 70);
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
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.Location = new System.Drawing.Point(418, 537);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.Size = new System.Drawing.Size(125, 20);
            this.kryptonCheckBox1.TabIndex = 7;
            this.kryptonCheckBox1.Values.Text = "kryptonCheckBox1";
            // 
            // grbEventoSelec
            // 
            this.grbEventoSelec.BackColor = System.Drawing.Color.Salmon;
            this.grbEventoSelec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbEventoSelec.Controls.Add(this.lblResponsavel);
            this.grbEventoSelec.Controls.Add(this.lblDetalhes);
            this.grbEventoSelec.Controls.Add(this.lblNomeEvento);
            this.grbEventoSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbEventoSelec.Location = new System.Drawing.Point(398, 92);
            this.grbEventoSelec.Margin = new System.Windows.Forms.Padding(1);
            this.grbEventoSelec.Name = "grbEventoSelec";
            this.grbEventoSelec.Size = new System.Drawing.Size(475, 441);
            this.grbEventoSelec.TabIndex = 8;
            this.grbEventoSelec.TabStop = false;
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblNomeEvento.Location = new System.Drawing.Point(198, 19);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(71, 29);
            this.lblNomeEvento.TabIndex = 0;
            this.lblNomeEvento.Values.Text = "Nome:";
            // 
            // lblDetalhes
            // 
            this.lblDetalhes.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel;
            this.lblDetalhes.Location = new System.Drawing.Point(198, 89);
            this.lblDetalhes.Name = "lblDetalhes";
            this.lblDetalhes.Size = new System.Drawing.Size(66, 20);
            this.lblDetalhes.TabIndex = 1;
            this.lblDetalhes.Values.Text = "Descrição:";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.ItalicPanel;
            this.lblResponsavel.Location = new System.Drawing.Point(6, 396);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(106, 20);
            this.lblResponsavel.TabIndex = 2;
            this.lblResponsavel.Values.Text = "Evento criado por: ";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minni.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(985, 579);
            this.Controls.Add(this.grbEventoSelec);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.lblInfoEventos);
            this.Controls.Add(this.lblInfosPost);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvEventos);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.grbEventoSelec.ResumeLayout(false);
            this.grbEventoSelec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgvEventos;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMenu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSair;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitulo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInfosPost;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblInfoEventos;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
        private System.Windows.Forms.GroupBox grbEventoSelec;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblResponsavel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDetalhes;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblNomeEvento;
    }
}