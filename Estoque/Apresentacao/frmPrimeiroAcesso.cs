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
    public partial class frmPrimeiroAcesso : MetroForm
    {
        public frmPrimeiroAcesso()
        {
            InitializeComponent();
        }

        private void frmPrimeiroAcesso_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarPrimeiroAcesso_Click(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text != "" && txtNovaSenha.Text != "" && txtConfirmarSenha.Text != "")
            {
                if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                {
                    try
                    {
                        clsPessoaNegocio pessoaNegocio = new clsPessoaNegocio();

                        string retorno = pessoaNegocio.AlterarAcesso(txtSenhaAtual.Text, txtNovaSenha.Text);

                        int id_Usuario = Convert.ToInt32(retorno);

                        if (id_Usuario == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\nOBRIGADO(A), \n\n SUA SENHA FOI ALTERADA COM SUCESSO !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\nATENÇÃO !\n\nA SENHA ATUAL ESTÁ INCORRETA !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenhaAtual.Clear();
                        txtSenhaAtual.Focus();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\nO CAMPO CONFIRMAR SENHA ESTÁ DIFERENTE DO CAMPO NOVA SENHA ", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nCAMPOS EM BRANCO !\n\nPREENCHA TODOS OS CAMPOS, POR FAVOR !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarPrimeiroAcesso_Click(object sender, EventArgs e)
        {
            frmLogin LOGIN = new frmLogin(0);
            Close();
            Dispose();
        }
    }
}
