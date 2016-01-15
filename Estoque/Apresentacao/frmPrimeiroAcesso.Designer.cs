namespace Apresentacao
{
    partial class frmPrimeiroAcesso
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
            this.lblTexto = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnSalvarPrimeiroAcesso = new System.Windows.Forms.Button();
            this.btnCancelarPrimeiroAcesso = new System.Windows.Forms.Button();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTexto.Location = new System.Drawing.Point(23, 60);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(411, 58);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Detectamos que este é seu primeiro acesso, e para sua segurança precisamos que re" +
    "defina sua senha";
            this.lblTexto.WrapToLine = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(23, 248);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(140, 25);
            this.metroLabel4.TabIndex = 97;
            this.metroLabel4.Text = "Confirmar Senha";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(23, 198);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 25);
            this.metroLabel3.TabIndex = 98;
            this.metroLabel3.Text = "Nova Senha";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(103, 25);
            this.metroLabel2.TabIndex = 99;
            this.metroLabel2.Text = "Senha Atual";
            // 
            // btnSalvarPrimeiroAcesso
            // 
            this.btnSalvarPrimeiroAcesso.BackColor = System.Drawing.Color.Silver;
            this.btnSalvarPrimeiroAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarPrimeiroAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPrimeiroAcesso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarPrimeiroAcesso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalvarPrimeiroAcesso.Location = new System.Drawing.Point(71, 297);
            this.btnSalvarPrimeiroAcesso.Name = "btnSalvarPrimeiroAcesso";
            this.btnSalvarPrimeiroAcesso.Size = new System.Drawing.Size(140, 50);
            this.btnSalvarPrimeiroAcesso.TabIndex = 3;
            this.btnSalvarPrimeiroAcesso.Text = "SALVAR";
            this.btnSalvarPrimeiroAcesso.UseVisualStyleBackColor = false;
            this.btnSalvarPrimeiroAcesso.Click += new System.EventHandler(this.btnSalvarPrimeiroAcesso_Click);
            // 
            // btnCancelarPrimeiroAcesso
            // 
            this.btnCancelarPrimeiroAcesso.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarPrimeiroAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPrimeiroAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPrimeiroAcesso.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPrimeiroAcesso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarPrimeiroAcesso.Location = new System.Drawing.Point(243, 297);
            this.btnCancelarPrimeiroAcesso.Name = "btnCancelarPrimeiroAcesso";
            this.btnCancelarPrimeiroAcesso.Size = new System.Drawing.Size(140, 50);
            this.btnCancelarPrimeiroAcesso.TabIndex = 4;
            this.btnCancelarPrimeiroAcesso.Text = "CANCELAR";
            this.btnCancelarPrimeiroAcesso.UseVisualStyleBackColor = false;
            this.btnCancelarPrimeiroAcesso.Click += new System.EventHandler(this.btnCancelarPrimeiroAcesso_Click);
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.Location = new System.Drawing.Point(174, 139);
            this.txtSenhaAtual.Multiline = true;
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(244, 34);
            this.txtSenhaAtual.TabIndex = 0;
            this.txtSenhaAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(174, 239);
            this.txtConfirmarSenha.Multiline = true;
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(244, 34);
            this.txtConfirmarSenha.TabIndex = 2;
            this.txtConfirmarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(174, 189);
            this.txtNovaSenha.Multiline = true;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(244, 34);
            this.txtNovaSenha.TabIndex = 1;
            this.txtNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPrimeiroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 370);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.btnCancelarPrimeiroAcesso);
            this.Controls.Add(this.btnSalvarPrimeiroAcesso);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblTexto);
            this.Name = "frmPrimeiroAcesso";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Bem Vindo";
            this.Load += new System.EventHandler(this.frmPrimeiroAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel lblTexto;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btnSalvarPrimeiroAcesso;
        private System.Windows.Forms.Button btnCancelarPrimeiroAcesso;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
    }
}