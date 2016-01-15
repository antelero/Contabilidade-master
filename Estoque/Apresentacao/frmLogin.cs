using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

using Negocio;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class frmLogin : MetroForm
    {
        int id_Usuario;

        //private int p;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(int p)
        {
            id_Usuario = p;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtNomeLogin.Text = "NOME";
            txtPassword.Text = "SENHA";

        }
        private void txtRecuperarSenha_Click(object sender, EventArgs e)
        {
            frmRecuperacaoLogin recuperarLogin = new frmRecuperacaoLogin();
            recuperarLogin.ShowDialog();
        }

        private void txtNomeLogin_Click(object sender, EventArgs e)
        {
            txtNomeLogin.Text = "";

        }

        private void btnValidarLogin_Click(object sender, EventArgs e)
        {
            if (txtNomeLogin.Text == "ADMIN" || txtNomeLogin.Text == "admin" && txtPassword.Text == "ADMIN" || txtPassword.Text == "admin")
            {
                frmPrimeiroAcesso PrimeiroAcesso = new frmPrimeiroAcesso();
                PrimeiroAcesso.ShowDialog();

                if (id_Usuario == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "\nSEJA BEM-VINDO ADMINISTRADOR, APROVEITE !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            if ((txtNomeLogin.Text != "") && (txtPassword.Text != ""))
            {
                try
                {

                    clsPessoa pessoa = new clsPessoa();

                    pessoa.Nome = txtNomeLogin.Text;
                    pessoa.Senha = txtPassword.Text;

                    clsPessoaNegocio pessoaNegocio = new clsPessoaNegocio();
                    string retorno = pessoaNegocio.Consultar(pessoa);

                    id_Usuario = Convert.ToInt16(retorno);

                    if (id_Usuario == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\nSEJA BEM-VINDO ADMINISTRADOR, APROVEITE !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmTelaControle admin = new frmTelaControle(id_Usuario);
                        admin.ShowDialog();
                        Close();
                        Dispose();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\nSEJA BEM-VINDO, APROVEITE !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmTelaControle usuario = new frmTelaControle(id_Usuario);
                        usuario.ShowDialog();
                        Close();
                        Dispose();
                    }
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nSEUS DADOS ESTÃO INCORRETOS !", "ATENÇÃO !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNomeLogin.Focus();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nCAMPOS EM BRANCO !\n\nPREENCHA TODOS OS CAMPOS, POR FAVOR !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeLogin.Clear();
                txtPassword.Clear();
                txtNomeLogin.Focus();
                this.DialogResult = DialogResult.No;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
    }
}
