namespace Apresentacao
{
    partial class frmClienteCadastrar
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
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnClienteLimpar = new MetroFramework.Controls.MetroButton();
            this.btnClienteCancelar = new MetroFramework.Controls.MetroButton();
            this.btnClienteSalvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeCliente = new MetroFramework.Controls.MetroTextBox();
            this.mskTxtCnpjCadastrarCliente = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
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
            this.btnNovoProduto.Image = global::Apresentacao.Properties.Resources.Cliente128px;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoProduto.Location = new System.Drawing.Point(21, 11);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(363, 174);
            this.btnNovoProduto.TabIndex = 56;
            this.btnNovoProduto.TabStop = false;
            this.btnNovoProduto.Text = "Cadastrar Cliente";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // btnClienteLimpar
            // 
            this.btnClienteLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteLimpar.Location = new System.Drawing.Point(146, 338);
            this.btnClienteLimpar.Name = "btnClienteLimpar";
            this.btnClienteLimpar.Size = new System.Drawing.Size(103, 27);
            this.btnClienteLimpar.TabIndex = 61;
            this.btnClienteLimpar.Text = "LIMPAR";
            this.btnClienteLimpar.UseSelectable = true;
            this.btnClienteLimpar.Click += new System.EventHandler(this.btnClienteLimpar_Click);
            // 
            // btnClienteCancelar
            // 
            this.btnClienteCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteCancelar.Location = new System.Drawing.Point(255, 338);
            this.btnClienteCancelar.Name = "btnClienteCancelar";
            this.btnClienteCancelar.Size = new System.Drawing.Size(103, 27);
            this.btnClienteCancelar.TabIndex = 60;
            this.btnClienteCancelar.Text = "CANCELAR";
            this.btnClienteCancelar.UseSelectable = true;
            this.btnClienteCancelar.Click += new System.EventHandler(this.btnClienteCancelar_Click);
            // 
            // btnClienteSalvar
            // 
            this.btnClienteSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteSalvar.Location = new System.Drawing.Point(37, 338);
            this.btnClienteSalvar.Name = "btnClienteSalvar";
            this.btnClienteSalvar.Size = new System.Drawing.Size(103, 27);
            this.btnClienteSalvar.TabIndex = 59;
            this.btnClienteSalvar.Text = "SALVAR";
            this.btnClienteSalvar.UseSelectable = true;
            this.btnClienteSalvar.Click += new System.EventHandler(this.btnClienteSalvar_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(38, 275);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 63;
            this.metroLabel4.Text = "CNPJ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(38, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 19);
            this.metroLabel3.TabIndex = 62;
            this.metroLabel3.Text = "Nome do Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeCliente.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtNomeCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCliente.Lines = new string[0];
            this.txtNomeCliente.Location = new System.Drawing.Point(38, 225);
            this.txtNomeCliente.MaxLength = 32767;
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.PasswordChar = '\0';
            this.txtNomeCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeCliente.SelectedText = "";
            this.txtNomeCliente.Size = new System.Drawing.Size(329, 35);
            this.txtNomeCliente.TabIndex = 57;
            this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCliente.UseSelectable = true;
            // 
            // mskTxtCnpjCadastrarCliente
            // 
            this.mskTxtCnpjCadastrarCliente.Location = new System.Drawing.Point(38, 297);
            this.mskTxtCnpjCadastrarCliente.Mask = "00.000.000/0000-00";
            this.mskTxtCnpjCadastrarCliente.Name = "mskTxtCnpjCadastrarCliente";
            this.mskTxtCnpjCadastrarCliente.Size = new System.Drawing.Size(141, 20);
            this.mskTxtCnpjCadastrarCliente.TabIndex = 58;
            // 
            // frmClienteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 388);
            this.Controls.Add(this.btnClienteLimpar);
            this.Controls.Add(this.btnClienteCancelar);
            this.Controls.Add(this.btnClienteSalvar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.mskTxtCnpjCadastrarCliente);
            this.Controls.Add(this.btnNovoProduto);
            this.Name = "frmClienteCadastrar";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.frmClienteCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoProduto;
        private MetroFramework.Controls.MetroButton btnClienteLimpar;
        private MetroFramework.Controls.MetroButton btnClienteCancelar;
        private MetroFramework.Controls.MetroButton btnClienteSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNomeCliente;
        private System.Windows.Forms.MaskedTextBox mskTxtCnpjCadastrarCliente;
    }
}