namespace Apresentacao
{
    partial class frmLogin
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
            this.txtNomeLogin = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtRecuperarSenha = new MetroFramework.Controls.MetroLabel();
            this.btnValidarLogin = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeLogin
            // 
            this.txtNomeLogin.BackColor = System.Drawing.Color.White;
            this.txtNomeLogin.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeLogin.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtNomeLogin.Lines = new string[0];
            this.txtNomeLogin.Location = new System.Drawing.Point(66, 326);
            this.txtNomeLogin.MaxLength = 32767;
            this.txtNomeLogin.Multiline = true;
            this.txtNomeLogin.Name = "txtNomeLogin";
            this.txtNomeLogin.PasswordChar = '\0';
            this.txtNomeLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeLogin.SelectedText = "";
            this.txtNomeLogin.Size = new System.Drawing.Size(376, 42);
            this.txtNomeLogin.TabIndex = 1;
            this.txtNomeLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeLogin.UseSelectable = true;
            this.txtNomeLogin.Click += new System.EventHandler(this.txtNomeLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(66, 374);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(376, 42);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtRecuperarSenha
            // 
            this.txtRecuperarSenha.AutoSize = true;
            this.txtRecuperarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRecuperarSenha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtRecuperarSenha.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.txtRecuperarSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRecuperarSenha.Location = new System.Drawing.Point(259, 419);
            this.txtRecuperarSenha.Name = "txtRecuperarSenha";
            this.txtRecuperarSenha.Size = new System.Drawing.Size(182, 25);
            this.txtRecuperarSenha.TabIndex = 2;
            this.txtRecuperarSenha.Text = "Esqueceu sua senha ?";
            this.txtRecuperarSenha.Click += new System.EventHandler(this.txtRecuperarSenha_Click);
            // 
            // btnValidarLogin
            // 
            this.btnValidarLogin.BackColor = System.Drawing.Color.Silver;
            this.btnValidarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarLogin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValidarLogin.Location = new System.Drawing.Point(66, 453);
            this.btnValidarLogin.Name = "btnValidarLogin";
            this.btnValidarLogin.Size = new System.Drawing.Size(376, 51);
            this.btnValidarLogin.TabIndex = 0;
            this.btnValidarLogin.Text = "ENTRAR";
            this.btnValidarLogin.UseVisualStyleBackColor = false;
            this.btnValidarLogin.Click += new System.EventHandler(this.btnValidarLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Apresentacao.Properties.Resources.LogoEmpresa;
            this.pictureBox2.Location = new System.Drawing.Point(23, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apresentacao.Properties.Resources.BeerCortadaPngBranco21;
            this.pictureBox1.Location = new System.Drawing.Point(7, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(508, 566);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnValidarLogin);
            this.Controls.Add(this.txtRecuperarSenha);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNomeLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNomeLogin;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel txtRecuperarSenha;
        private System.Windows.Forms.Button btnValidarLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}