namespace Apresentacao
{
    partial class frmCadastrarUsuario
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
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtSobreNome = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtConfirmarSenhar = new MetroFramework.Controls.MetroTextBox();
            this.btnSalvarUsuario = new MetroFramework.Controls.MetroButton();
            this.dtDataNascimento = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Lines = new string[] {
        "NOME"};
            this.txtNome.Location = new System.Drawing.Point(23, 74);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(202, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "NOME";
            this.txtNome.UseSelectable = true;
            // 
            // txtSobreNome
            // 
            this.txtSobreNome.Lines = new string[] {
        "SOBRENOME"};
            this.txtSobreNome.Location = new System.Drawing.Point(231, 74);
            this.txtSobreNome.MaxLength = 32767;
            this.txtSobreNome.Name = "txtSobreNome";
            this.txtSobreNome.PasswordChar = '\0';
            this.txtSobreNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobreNome.SelectedText = "";
            this.txtSobreNome.Size = new System.Drawing.Size(137, 23);
            this.txtSobreNome.TabIndex = 3;
            this.txtSobreNome.Text = "SOBRENOME";
            this.txtSobreNome.UseSelectable = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Lines = new string[] {
        "E-MAIL"};
            this.txtEmail.Location = new System.Drawing.Point(23, 103);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(345, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "E-MAIL";
            this.txtEmail.UseSelectable = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Lines = new string[] {
        "SENHA"};
            this.txtSenha.Location = new System.Drawing.Point(23, 167);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(170, 23);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.UseSelectable = true;
            // 
            // txtConfirmarSenhar
            // 
            this.txtConfirmarSenhar.Lines = new string[] {
        "CONFIRMAR SENHA"};
            this.txtConfirmarSenhar.Location = new System.Drawing.Point(198, 167);
            this.txtConfirmarSenhar.MaxLength = 32767;
            this.txtConfirmarSenhar.Name = "txtConfirmarSenhar";
            this.txtConfirmarSenhar.PasswordChar = '\0';
            this.txtConfirmarSenhar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmarSenhar.SelectedText = "";
            this.txtConfirmarSenhar.Size = new System.Drawing.Size(170, 23);
            this.txtConfirmarSenhar.TabIndex = 7;
            this.txtConfirmarSenhar.Text = "CONFIRMAR SENHA";
            this.txtConfirmarSenhar.UseSelectable = true;
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Location = new System.Drawing.Point(90, 205);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(209, 23);
            this.btnSalvarUsuario.TabIndex = 9;
            this.btnSalvarUsuario.Text = "SALVAR";
            this.btnSalvarUsuario.UseSelectable = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Location = new System.Drawing.Point(23, 132);
            this.dtDataNascimento.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(345, 29);
            this.dtDataNascimento.TabIndex = 10;
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 245);
            this.Controls.Add(this.dtDataNascimento);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.txtConfirmarSenhar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSobreNome);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastrarUsuario";
            this.Text = "CADASTRAR USUÁRIO";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmCadastrarUsuario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtSobreNome;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtConfirmarSenhar;
        private MetroFramework.Controls.MetroButton btnSalvarUsuario;
        private MetroFramework.Controls.MetroDateTime dtDataNascimento;
    }
}