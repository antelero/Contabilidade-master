namespace Apresentacao
{
    partial class frmFuncoesSistema
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 89);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(254, 54);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "CADASTRAR USUARIO";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 149);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(254, 54);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "CADASTRAR ITENS";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(23, 209);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(254, 54);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "metroButton3";
            this.metroButton3.UseSelectable = true;
            // 
            // frmFuncoesSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "frmFuncoesSistema";
            this.Text = "OPÇÕES DO SISTEMA";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}