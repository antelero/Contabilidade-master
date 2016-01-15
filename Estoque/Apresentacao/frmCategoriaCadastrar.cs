using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocio;
using MetroFramework.Forms;
namespace Apresentacao
{
    public partial class frmCategoriaCadastrar : MetroForm
    {
        public frmCategoriaCadastrar()
        {
            InitializeComponent();
        }

        private void frmCategoriaCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoriaSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCategoriaCadastrar.Text != "")
            {
                clsTipo T = new clsTipo();
                clsTipoNegocio TN = new clsTipoNegocio();

                T.Descricao = txtNomeCategoriaCadastrar.Text;

                DialogResult resp = MetroFramework.MetroMessageBox.Show(this,
                                                                        "\nCATEGORIA: " + txtNomeCategoriaCadastrar.Text,
                                                                        "CADASTRAR ESSA CATEGORIA ?",
                                                                        MessageBoxButtons.YesNo,
                                                                        MessageBoxIcon.Information);

                if (resp == DialogResult.Yes)
                {
                    string retorno = TN.CadastrarCategoria(T);

                    MetroFramework.MetroMessageBox.Show(this,
                                                        "\n\nCATEGORIA CADASTRADA COM SUCESSO" 
                                                        +"\nCOD: " + retorno,
                                                        "INFORMAÇÃO !",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);

                    DialogResult resp2 =  MetroFramework.MetroMessageBox.Show(this,
                                                        "DESEJA CONTINUAR ?",
                                                        "INFORMAÇÃO !",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Information);

                    if (resp2 == DialogResult.Yes)
                    {
                        txtNomeCategoriaCadastrar.Clear();
                        txtNomeCategoriaCadastrar.Focus();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nCAMPOS EM BRANCO !\n\nPREENCHA TODOS OS CAMPOS, POR FAVOR !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCategoriaCadastrar.Focus();
            }
        }

        private void btnCategoriaLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCategoriaCadastrar.Clear();
            txtNomeCategoriaCadastrar.Focus();
        }

        private void btnCategoriaCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
