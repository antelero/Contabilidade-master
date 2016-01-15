namespace Apresentacao
{
    partial class frmCategoriaCadastrar
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
            this.btnCategoriaLimpar = new MetroFramework.Controls.MetroButton();
            this.btnCategoriaCancelar = new MetroFramework.Controls.MetroButton();
            this.btnCategoriaSalvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeCategoriaCadastrar = new MetroFramework.Controls.MetroTextBox();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategoriaLimpar
            // 
            this.btnCategoriaLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoriaLimpar.Location = new System.Drawing.Point(142, 288);
            this.btnCategoriaLimpar.Name = "btnCategoriaLimpar";
            this.btnCategoriaLimpar.Size = new System.Drawing.Size(103, 27);
            this.btnCategoriaLimpar.TabIndex = 31;
            this.btnCategoriaLimpar.Text = "LIMPAR";
            this.btnCategoriaLimpar.UseSelectable = true;
            this.btnCategoriaLimpar.Click += new System.EventHandler(this.btnCategoriaLimpar_Click);
            // 
            // btnCategoriaCancelar
            // 
            this.btnCategoriaCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoriaCancelar.Location = new System.Drawing.Point(251, 288);
            this.btnCategoriaCancelar.Name = "btnCategoriaCancelar";
            this.btnCategoriaCancelar.Size = new System.Drawing.Size(103, 27);
            this.btnCategoriaCancelar.TabIndex = 30;
            this.btnCategoriaCancelar.Text = "CANCELAR";
            this.btnCategoriaCancelar.UseSelectable = true;
            this.btnCategoriaCancelar.Click += new System.EventHandler(this.btnCategoriaCancelar_Click);
            // 
            // btnCategoriaSalvar
            // 
            this.btnCategoriaSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoriaSalvar.Location = new System.Drawing.Point(33, 288);
            this.btnCategoriaSalvar.Name = "btnCategoriaSalvar";
            this.btnCategoriaSalvar.Size = new System.Drawing.Size(103, 27);
            this.btnCategoriaSalvar.TabIndex = 29;
            this.btnCategoriaSalvar.Text = "SALVAR";
            this.btnCategoriaSalvar.UseSelectable = true;
            this.btnCategoriaSalvar.Click += new System.EventHandler(this.btnCategoriaSalvar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(30, 206);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 33;
            this.metroLabel3.Text = "Nome da Categoria";
            // 
            // txtNomeCategoriaCadastrar
            // 
            this.txtNomeCategoriaCadastrar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNomeCategoriaCadastrar.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtNomeCategoriaCadastrar.ForeColor = System.Drawing.Color.Black;
            this.txtNomeCategoriaCadastrar.Lines = new string[0];
            this.txtNomeCategoriaCadastrar.Location = new System.Drawing.Point(30, 228);
            this.txtNomeCategoriaCadastrar.MaxLength = 32767;
            this.txtNomeCategoriaCadastrar.Multiline = true;
            this.txtNomeCategoriaCadastrar.Name = "txtNomeCategoriaCadastrar";
            this.txtNomeCategoriaCadastrar.PasswordChar = '\0';
            this.txtNomeCategoriaCadastrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeCategoriaCadastrar.SelectedText = "";
            this.txtNomeCategoriaCadastrar.Size = new System.Drawing.Size(329, 35);
            this.txtNomeCategoriaCadastrar.TabIndex = 28;
            this.txtNomeCategoriaCadastrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCategoriaCadastrar.UseSelectable = true;
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
            this.btnNovoProduto.Image = global::Apresentacao.Properties.Resources.Categoria128px;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoProduto.Location = new System.Drawing.Point(16, 32);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(352, 153);
            this.btnNovoProduto.TabIndex = 32;
            this.btnNovoProduto.TabStop = false;
            this.btnNovoProduto.Text = "Nova Categoria";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // frmCategoriaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 338);
            this.Controls.Add(this.btnCategoriaLimpar);
            this.Controls.Add(this.btnCategoriaCancelar);
            this.Controls.Add(this.btnCategoriaSalvar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtNomeCategoriaCadastrar);
            this.Controls.Add(this.btnNovoProduto);
            this.Name = "frmCategoriaCadastrar";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.frmCategoriaCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCategoriaLimpar;
        private MetroFramework.Controls.MetroButton btnCategoriaCancelar;
        private MetroFramework.Controls.MetroButton btnCategoriaSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNomeCategoriaCadastrar;
        private System.Windows.Forms.Button btnNovoProduto;
    }
}