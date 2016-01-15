namespace Apresentacao
{
    partial class frmProdutoVender
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
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.dtEntradaVenda = new MetroFramework.Controls.MetroDateTime();
            this.txtDescMovVenda = new System.Windows.Forms.TextBox();
            this.txtQtdeVenda = new System.Windows.Forms.TextBox();
            this.txtCategoriaVenda = new System.Windows.Forms.TextBox();
            this.txtDescricaoVenda = new System.Windows.Forms.TextBox();
            this.dtSaidaVenda = new MetroFramework.Controls.MetroDateTime();
            this.cboCliente = new MetroFramework.Controls.MetroComboBox();
            this.lblCadastrarNovoFornecedor = new MetroFramework.Controls.MetroLabel();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(278, 581);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 27);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 27);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(27, 582);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 27);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtEntradaVenda
            // 
            this.dtEntradaVenda.Enabled = false;
            this.dtEntradaVenda.Location = new System.Drawing.Point(32, 476);
            this.dtEntradaVenda.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEntradaVenda.Name = "dtEntradaVenda";
            this.dtEntradaVenda.Size = new System.Drawing.Size(344, 29);
            this.dtEntradaVenda.TabIndex = 28;
            // 
            // txtDescMovVenda
            // 
            this.txtDescMovVenda.BackColor = System.Drawing.Color.White;
            this.txtDescMovVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescMovVenda.Location = new System.Drawing.Point(32, 295);
            this.txtDescMovVenda.Multiline = true;
            this.txtDescMovVenda.Name = "txtDescMovVenda";
            this.txtDescMovVenda.ReadOnly = true;
            this.txtDescMovVenda.Size = new System.Drawing.Size(344, 29);
            this.txtDescMovVenda.TabIndex = 38;
            // 
            // txtQtdeVenda
            // 
            this.txtQtdeVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeVenda.Location = new System.Drawing.Point(285, 413);
            this.txtQtdeVenda.Multiline = true;
            this.txtQtdeVenda.Name = "txtQtdeVenda";
            this.txtQtdeVenda.Size = new System.Drawing.Size(91, 29);
            this.txtQtdeVenda.TabIndex = 39;
            // 
            // txtCategoriaVenda
            // 
            this.txtCategoriaVenda.BackColor = System.Drawing.Color.White;
            this.txtCategoriaVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaVenda.Location = new System.Drawing.Point(32, 413);
            this.txtCategoriaVenda.Multiline = true;
            this.txtCategoriaVenda.Name = "txtCategoriaVenda";
            this.txtCategoriaVenda.ReadOnly = true;
            this.txtCategoriaVenda.Size = new System.Drawing.Size(237, 29);
            this.txtCategoriaVenda.TabIndex = 40;
            // 
            // txtDescricaoVenda
            // 
            this.txtDescricaoVenda.BackColor = System.Drawing.Color.White;
            this.txtDescricaoVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoVenda.Location = new System.Drawing.Point(32, 354);
            this.txtDescricaoVenda.Multiline = true;
            this.txtDescricaoVenda.Name = "txtDescricaoVenda";
            this.txtDescricaoVenda.ReadOnly = true;
            this.txtDescricaoVenda.Size = new System.Drawing.Size(344, 29);
            this.txtDescricaoVenda.TabIndex = 41;
            // 
            // dtSaidaVenda
            // 
            this.dtSaidaVenda.Enabled = false;
            this.dtSaidaVenda.Location = new System.Drawing.Point(32, 538);
            this.dtSaidaVenda.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtSaidaVenda.Name = "dtSaidaVenda";
            this.dtSaidaVenda.Size = new System.Drawing.Size(344, 29);
            this.dtSaidaVenda.TabIndex = 42;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.ItemHeight = 23;
            this.cboCliente.Items.AddRange(new object[] {
            "MOQUIDESIA LTDA"});
            this.cboCliente.Location = new System.Drawing.Point(32, 225);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(344, 29);
            this.cboCliente.TabIndex = 53;
            this.cboCliente.UseSelectable = true;
            // 
            // lblCadastrarNovoFornecedor
            // 
            this.lblCadastrarNovoFornecedor.AutoSize = true;
            this.lblCadastrarNovoFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastrarNovoFornecedor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCadastrarNovoFornecedor.Location = new System.Drawing.Point(215, 257);
            this.lblCadastrarNovoFornecedor.Name = "lblCadastrarNovoFornecedor";
            this.lblCadastrarNovoFornecedor.Size = new System.Drawing.Size(161, 19);
            this.lblCadastrarNovoFornecedor.TabIndex = 54;
            this.lblCadastrarNovoFornecedor.Text = "Cadastrar Novo Cliente ?";
            this.lblCadastrarNovoFornecedor.Click += new System.EventHandler(this.lblCadastrarNovoFornecedor_Click);
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
            this.btnNovoProduto.Image = global::Apresentacao.Properties.Resources.Venda128px;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoProduto.Location = new System.Drawing.Point(23, 22);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(363, 150);
            this.btnNovoProduto.TabIndex = 55;
            this.btnNovoProduto.TabStop = false;
            this.btnNovoProduto.Text = "Vender Produto";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(32, 203);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(51, 19);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "Cliente";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(32, 273);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 57;
            this.metroLabel1.Text = "Movimentação";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(32, 332);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "Descrição";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(32, 391);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 59;
            this.metroLabel3.Text = "Categoria";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(32, 454);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.TabIndex = 61;
            this.metroLabel5.Text = "Data de Entrada";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(32, 516);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 19);
            this.metroLabel6.TabIndex = 62;
            this.metroLabel6.Text = "Data de Saída";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(295, 391);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(81, 19);
            this.metroLabel8.TabIndex = 63;
            this.metroLabel8.Text = "Quantidade";
            // 
            // frmProdutoVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 630);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.lblCadastrarNovoFornecedor);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.dtSaidaVenda);
            this.Controls.Add(this.txtDescricaoVenda);
            this.Controls.Add(this.txtCategoriaVenda);
            this.Controls.Add(this.txtQtdeVenda);
            this.Controls.Add(this.txtDescMovVenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtEntradaVenda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmProdutoVender";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.frmProdutoVender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroDateTime dtEntradaVenda;
        private System.Windows.Forms.TextBox txtDescMovVenda;
        private System.Windows.Forms.TextBox txtQtdeVenda;
        private System.Windows.Forms.TextBox txtCategoriaVenda;
        private System.Windows.Forms.TextBox txtDescricaoVenda;
        private MetroFramework.Controls.MetroDateTime dtSaidaVenda;
        private MetroFramework.Controls.MetroComboBox cboCliente;
        private MetroFramework.Controls.MetroLabel lblCadastrarNovoFornecedor;
        private System.Windows.Forms.Button btnNovoProduto;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}