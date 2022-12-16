namespace Minni
{
    partial class login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lblTitulo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txbSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txbUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUsername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSenha = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnEntrar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblLinkCadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCustom1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            // 
            // lblTitulo
            // 
            this.lblTitulo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblTitulo.Location = new System.Drawing.Point(249, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Values.Text = "Bem Vindo! ";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(208, 135);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '•';
            this.txbSenha.Size = new System.Drawing.Size(212, 41);
            this.txbSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txbSenha.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txbSenha.StateCommon.Border.Rounding = 18;
            this.txbSenha.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txbSenha.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.TabIndex = 2;
            this.txbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(208, 88);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(212, 41);
            this.txbUsername.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txbUsername.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txbUsername.StateCommon.Border.Rounding = 18;
            this.txbUsername.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txbUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.TabIndex = 1;
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUsername
            // 
            this.lblUsername.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblUsername.Location = new System.Drawing.Point(124, 99);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 20);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Values.Text = "Apelido: ";
            // 
            // lblSenha
            // 
            this.lblSenha.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldPanel;
            this.lblSenha.Location = new System.Drawing.Point(131, 145);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 20);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Values.Text = "Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnEntrar.Location = new System.Drawing.Point(261, 194);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(90, 25);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Values.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLinkCadastro
            // 
            this.lblLinkCadastro.AutoSize = true;
            this.lblLinkCadastro.LinkColor = System.Drawing.Color.Black;
            this.lblLinkCadastro.Location = new System.Drawing.Point(411, 228);
            this.lblLinkCadastro.Name = "lblLinkCadastro";
            this.lblLinkCadastro.Size = new System.Drawing.Size(154, 13);
            this.lblLinkCadastro.TabIndex = 6;
            this.lblLinkCadastro.TabStop = true;
            this.lblLinkCadastro.Text = "Não tem acesso? Crie um aqui.";
            this.lblLinkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCadastro_LinkClicked);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(577, 246);
            this.Controls.Add(this.lblLinkCadastro);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormCustom1;
            this.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.FormCustom1;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateInactive.Border.Color1 = System.Drawing.Color.White;
            this.StateInactive.Border.Color2 = System.Drawing.Color.White;
            this.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Border.Rounding = 16;
            this.StateInactive.Border.Width = -5;
            this.StateInactive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateInactive.Header.Border.Rounding = -10;
            this.StateInactive.Header.Border.Width = -10;
            this.Text = "Minni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTitulo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txbUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEntrar;
        private System.Windows.Forms.LinkLabel lblLinkCadastro;
    }
}

