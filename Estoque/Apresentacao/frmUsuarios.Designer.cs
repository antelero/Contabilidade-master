namespace Apresentacao
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnCancelarExclusao = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dtGridViewUsuario = new MetroFramework.Controls.MetroGrid();
            this.colDescricaoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSobreNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnExcluirUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirUsuario.Location = new System.Drawing.Point(160, 337);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(202, 37);
            this.btnExcluirUsuario.TabIndex = 3;
            this.btnExcluirUsuario.Text = "EXCLUIR";
            this.btnExcluirUsuario.UseVisualStyleBackColor = false;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnCancelarExclusao
            // 
            this.btnCancelarExclusao.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarExclusao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarExclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarExclusao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarExclusao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelarExclusao.Location = new System.Drawing.Point(576, 337);
            this.btnCancelarExclusao.Name = "btnCancelarExclusao";
            this.btnCancelarExclusao.Size = new System.Drawing.Size(202, 37);
            this.btnCancelarExclusao.TabIndex = 4;
            this.btnCancelarExclusao.Text = "SAIR";
            this.btnCancelarExclusao.UseVisualStyleBackColor = false;
            this.btnCancelarExclusao.Click += new System.EventHandler(this.btnCancelarExclusao_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Silver;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterar.Location = new System.Drawing.Point(368, 337);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(202, 37);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dtGridViewUsuario
            // 
            this.dtGridViewUsuario.AllowUserToAddRows = false;
            this.dtGridViewUsuario.AllowUserToDeleteRows = false;
            this.dtGridViewUsuario.AllowUserToResizeRows = false;
            this.dtGridViewUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtGridViewUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridViewUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDescricaoItem,
            this.colSobreNome,
            this.colDataNascimento,
            this.colEmail,
            this.colSenha,
            this.colNivel});
            this.dtGridViewUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewUsuario.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtGridViewUsuario.EnableHeadersVisualStyles = false;
            this.dtGridViewUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtGridViewUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtGridViewUsuario.Location = new System.Drawing.Point(23, 178);
            this.dtGridViewUsuario.Name = "dtGridViewUsuario";
            this.dtGridViewUsuario.ReadOnly = true;
            this.dtGridViewUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtGridViewUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridViewUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewUsuario.Size = new System.Drawing.Size(893, 153);
            this.dtGridViewUsuario.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtGridViewUsuario.TabIndex = 30;
            // 
            // colDescricaoItem
            // 
            this.colDescricaoItem.DataPropertyName = "Nome";
            this.colDescricaoItem.HeaderText = "Nome";
            this.colDescricaoItem.Name = "colDescricaoItem";
            this.colDescricaoItem.ReadOnly = true;
            this.colDescricaoItem.ToolTipText = "click aqui duas vezes";
            // 
            // colSobreNome
            // 
            this.colSobreNome.DataPropertyName = "SobreNome";
            this.colSobreNome.HeaderText = "SobreNome";
            this.colSobreNome.Name = "colSobreNome";
            this.colSobreNome.ReadOnly = true;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.DataPropertyName = "DataNascimento";
            this.colDataNascimento.HeaderText = "DataNascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 250;
            // 
            // colSenha
            // 
            this.colSenha.DataPropertyName = "Senha";
            this.colSenha.HeaderText = "Senha";
            this.colSenha.Name = "colSenha";
            this.colSenha.ReadOnly = true;
            // 
            // colNivel
            // 
            this.colNivel.DataPropertyName = "idNivel";
            this.colNivel.HeaderText = "Nivel";
            this.colNivel.Name = "colNivel";
            this.colNivel.ReadOnly = true;
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
            this.btnNovoProduto.Image = global::Apresentacao.Properties.Resources.UserDeletedblue128px;
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovoProduto.Location = new System.Drawing.Point(254, 14);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(430, 158);
            this.btnNovoProduto.TabIndex = 27;
            this.btnNovoProduto.TabStop = false;
            this.btnNovoProduto.Text = "Configurar Usuários";
            this.btnNovoProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 399);
            this.Controls.Add(this.dtGridViewUsuario);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.btnCancelarExclusao);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Name = "frmUsuarios";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.Button btnCancelarExclusao;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnAlterar;
        private MetroFramework.Controls.MetroGrid dtGridViewUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricaoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSobreNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNivel;


    }
}