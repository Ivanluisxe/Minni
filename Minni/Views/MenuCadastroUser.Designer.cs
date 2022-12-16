namespace Minni.Views
{
    partial class MenuCadastroUser
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
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.Rounding = 16;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(79, 43);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(144, 20);
            this.txbUsername.TabIndex = 0;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(79, 81);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(144, 20);
            this.txbNome.TabIndex = 1;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.Location = new System.Drawing.Point(79, 121);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(144, 20);
            this.txbSobrenome.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(79, 157);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(144, 20);
            this.txbSenha.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(80, 193);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(143, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(35, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(26, 46);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(45, 13);
            this.lblApelido.TabIndex = 6;
            this.lblApelido.Text = "Apelido:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(12, 124);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome.TabIndex = 7;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(30, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(76, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(109, 18);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Novo Usuário:";
            // 
            // MenuCadastroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 242);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbUsername);
            this.Name = "MenuCadastroUser";
            this.ShowIcon = false;
            this.Text = "Novo Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTitulo;
    }
}