namespace Apresentacao
{
    partial class frmVendas
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
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.dtEntradaVenda = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtDescMovVenda = new System.Windows.Forms.TextBox();
            this.txtQtdeVenda = new System.Windows.Forms.TextBox();
            this.txtCategoriaVenda = new System.Windows.Forms.TextBox();
            this.txtDescricaoVenda = new System.Windows.Forms.TextBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoVenda.Location = new System.Drawing.Point(309, 148);
            this.txtPrecoVenda.Multiline = true;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(105, 32);
            this.txtPrecoVenda.TabIndex = 34;
            this.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(320, 387);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 27);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 27);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseSelectable = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(27, 388);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 27);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseSelectable = true;
            // 
            // dtEntradaVenda
            // 
            this.dtEntradaVenda.Enabled = false;
            this.dtEntradaVenda.Location = new System.Drawing.Point(27, 272);
            this.dtEntradaVenda.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEntradaVenda.Name = "dtEntradaVenda";
            this.dtEntradaVenda.Size = new System.Drawing.Size(388, 29);
            this.dtEntradaVenda.TabIndex = 28;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(141, 30);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(172, 19);
            this.metroLabel6.TabIndex = 37;
            this.metroLabel6.Text = "INFORMAÇÕES DA VENDA";
            // 
            // txtDescMovVenda
            // 
            this.txtDescMovVenda.BackColor = System.Drawing.Color.White;
            this.txtDescMovVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescMovVenda.Location = new System.Drawing.Point(27, 85);
            this.txtDescMovVenda.Multiline = true;
            this.txtDescMovVenda.Name = "txtDescMovVenda";
            this.txtDescMovVenda.ReadOnly = true;
            this.txtDescMovVenda.Size = new System.Drawing.Size(388, 33);
            this.txtDescMovVenda.TabIndex = 38;
            // 
            // txtQtdeVenda
            // 
            this.txtQtdeVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeVenda.Location = new System.Drawing.Point(309, 210);
            this.txtQtdeVenda.Multiline = true;
            this.txtQtdeVenda.Name = "txtQtdeVenda";
            this.txtQtdeVenda.Size = new System.Drawing.Size(105, 33);
            this.txtQtdeVenda.TabIndex = 39;
            // 
            // txtCategoriaVenda
            // 
            this.txtCategoriaVenda.BackColor = System.Drawing.Color.White;
            this.txtCategoriaVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaVenda.Location = new System.Drawing.Point(27, 210);
            this.txtCategoriaVenda.Multiline = true;
            this.txtCategoriaVenda.Name = "txtCategoriaVenda";
            this.txtCategoriaVenda.ReadOnly = true;
            this.txtCategoriaVenda.Size = new System.Drawing.Size(263, 33);
            this.txtCategoriaVenda.TabIndex = 40;
            // 
            // txtDescricaoVenda
            // 
            this.txtDescricaoVenda.BackColor = System.Drawing.Color.White;
            this.txtDescricaoVenda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoVenda.Location = new System.Drawing.Point(26, 148);
            this.txtDescricaoVenda.Multiline = true;
            this.txtDescricaoVenda.Name = "txtDescricaoVenda";
            this.txtDescricaoVenda.ReadOnly = true;
            this.txtDescricaoVenda.Size = new System.Drawing.Size(264, 33);
            this.txtDescricaoVenda.TabIndex = 41;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(26, 335);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(388, 29);
            this.metroDateTime1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "MOVIMENTAÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "QUANTIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "PREÇO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "CATEGORIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "DATA DE ENTRADA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "DATA DA SAÍDA";
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 440);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.txtDescricaoVenda);
            this.Controls.Add(this.txtCategoriaVenda);
            this.Controls.Add(this.txtQtdeVenda);
            this.Controls.Add(this.txtDescMovVenda);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtEntradaVenda);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVendas";
            this.Padding = new System.Windows.Forms.Padding(23, 69, 23, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecoVenda;
        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroDateTime dtEntradaVenda;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtDescMovVenda;
        private System.Windows.Forms.TextBox txtQtdeVenda;
        private System.Windows.Forms.TextBox txtCategoriaVenda;
        private System.Windows.Forms.TextBox txtDescricaoVenda;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}