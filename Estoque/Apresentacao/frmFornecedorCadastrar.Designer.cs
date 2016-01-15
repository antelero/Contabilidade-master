namespace Apresentacao
{
    partial class frmFornecedorCadastrar
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
            this.mskTxtCnpjCadastrar = new System.Windows.Forms.MaskedTextBox();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.txtNomeFantasiaCadastrar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnFornecedorSalvar = new MetroFramework.Controls.MetroButton();
            this.btnFornecedorCancelar = new MetroFramework.Controls.MetroButton();
            this.btnFornecedorLimpar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mskTxtCnpjCadastrar
            // 
            this.mskTxtCnpjCadastrar.Location = new System.Drawing.Point(41, 297);
            this.mskTxtCnpjCadastrar.Mask = "00.000.000/0000-00";
            this.mskTxtCnpjCadastrar.Name = "mskTxtCnpjCadastrar";
            this.mskTxtCnpjCadastrar.Size = new System.Drawing.Size(141, 20);
            this.mskTxtCnpjCadastrar.TabIndex = 1;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.Color.White;
            this.btnNovoProduto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNovoProduto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.Image = global::Apresentacao.Properties.Resources.Fornecedor128px;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoProduto.Location = new System.Drawing.Point(26, 40);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(352, 153);
            this.btnNovoProduto.TabIndex = 25;
            this.btnNovoProduto.TabStop = false;
            this.btnNovoProduto.Text = "Novo Fornecedor";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // txtNomeFantasiaCadastrar
            // 
            this.txtNomeFantasiaCadastrar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeFantasiaCadastrar.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtNomeFantasiaCadastrar.ForeColor = System.Drawing.Color.Black;
            this.txtNomeFantasiaCadastrar.Lines = new string[0];
            this.txtNomeFantasiaCadastrar.Location = new System.Drawing.Point(41, 225);
            this.txtNomeFantasiaCadastrar.MaxLength = 32767;
            this.txtNomeFantasiaCadastrar.Multiline = true;
            this.txtNomeFantasiaCadastrar.Name = "txtNomeFantasiaCadastrar";
            this.txtNomeFantasiaCadastrar.PasswordChar = '\0';
            this.txtNomeFantasiaCadastrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeFantasiaCadastrar.SelectedText = "";
            this.txtNomeFantasiaCadastrar.Size = new System.Drawing.Size(329, 35);
            this.txtNomeFantasiaCadastrar.TabIndex = 0;
            this.txtNomeFantasiaCadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeFantasiaCadastrar.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(41, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "Nome Fantasia";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(41, 275);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "CNPJ";
            // 
            // btnFornecedorSalvar
            // 
            this.btnFornecedorSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedorSalvar.Location = new System.Drawing.Point(40, 338);
            this.btnFornecedorSalvar.Name = "btnFornecedorSalvar";
            this.btnFornecedorSalvar.Size = new System.Drawing.Size(103, 27);
            this.btnFornecedorSalvar.TabIndex = 2;
            this.btnFornecedorSalvar.Text = "SALVAR";
            this.btnFornecedorSalvar.UseSelectable = true;
            this.btnFornecedorSalvar.Click += new System.EventHandler(this.btnFornecedorSalvar_Click_1);
            // 
            // btnFornecedorCancelar
            // 
            this.btnFornecedorCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedorCancelar.Location = new System.Drawing.Point(258, 338);
            this.btnFornecedorCancelar.Name = "btnFornecedorCancelar";
            this.btnFornecedorCancelar.Size = new System.Drawing.Size(103, 27);
            this.btnFornecedorCancelar.TabIndex = 3;
            this.btnFornecedorCancelar.Text = "CANCELAR";
            this.btnFornecedorCancelar.UseSelectable = true;
            this.btnFornecedorCancelar.Click += new System.EventHandler(this.btnFornecedorCancelar_Click);
            // 
            // btnFornecedorLimpar
            // 
            this.btnFornecedorLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFornecedorLimpar.Location = new System.Drawing.Point(149, 338);
            this.btnFornecedorLimpar.Name = "btnFornecedorLimpar";
            this.btnFornecedorLimpar.Size = new System.Drawing.Size(103, 27);
            this.btnFornecedorLimpar.TabIndex = 4;
            this.btnFornecedorLimpar.Text = "LIMPAR";
            this.btnFornecedorLimpar.UseSelectable = true;
            this.btnFornecedorLimpar.Click += new System.EventHandler(this.btnFornecedorLimpar_Click);
            // 
            // frmFornecedorCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 388);
            this.Controls.Add(this.btnFornecedorLimpar);
            this.Controls.Add(this.btnFornecedorCancelar);
            this.Controls.Add(this.btnFornecedorSalvar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNomeFantasiaCadastrar);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.mskTxtCnpjCadastrar);
            this.Name = "frmFornecedorCadastrar";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmFornecedorCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTxtCnpjCadastrar;
        private System.Windows.Forms.Button btnNovoProduto;
        private MetroFramework.Controls.MetroTextBox txtNomeFantasiaCadastrar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnFornecedorSalvar;
        private MetroFramework.Controls.MetroButton btnFornecedorCancelar;
        private MetroFramework.Controls.MetroButton btnFornecedorLimpar;
    }
}