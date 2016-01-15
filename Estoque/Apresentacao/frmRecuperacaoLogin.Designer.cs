namespace Apresentacao
{
    partial class frmRecuperacaoLogin
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
            this.txtRecuperarSenha = new MetroFramework.Controls.MetroTextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRecuperarSenha
            // 
            this.txtRecuperarSenha.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRecuperarSenha.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtRecuperarSenha.ForeColor = System.Drawing.Color.Black;
            this.txtRecuperarSenha.Lines = new string[0];
            this.txtRecuperarSenha.Location = new System.Drawing.Point(90, 209);
            this.txtRecuperarSenha.MaxLength = 32767;
            this.txtRecuperarSenha.Multiline = true;
            this.txtRecuperarSenha.Name = "txtRecuperarSenha";
            this.txtRecuperarSenha.PasswordChar = '\0';
            this.txtRecuperarSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecuperarSenha.SelectedText = "";
            this.txtRecuperarSenha.Size = new System.Drawing.Size(329, 35);
            this.txtRecuperarSenha.TabIndex = 1;
            this.txtRecuperarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecuperarSenha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecuperarSenha.UseSelectable = true;
            this.txtRecuperarSenha.Click += new System.EventHandler(this.txtRecuperarSenha_Click);
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.BackColor = System.Drawing.Color.Silver;
            this.btnEnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEnviarEmail.Location = new System.Drawing.Point(198, 255);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(122, 51);
            this.btnEnviarEmail.TabIndex = 0;
            this.btnEnviarEmail.Text = "ENVIAR";
            this.btnEnviarEmail.UseVisualStyleBackColor = false;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click_1);
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.Color.White;
            this.btnNovoProduto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNovoProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.Image = global::Apresentacao.Properties.Resources.EnviarEmail128px;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoProduto.Location = new System.Drawing.Point(6, 40);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(496, 163);
            this.btnNovoProduto.TabIndex = 27;
            this.btnNovoProduto.TabStop = false;
            this.btnNovoProduto.Text = "Recuperar Senha";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // frmRecuperacaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(508, 329);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.txtRecuperarSenha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperacaoLogin";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmRecuperacaoLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtRecuperarSenha;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnNovoProduto;
    }
}