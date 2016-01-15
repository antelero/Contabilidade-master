using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using MetroFramework.Forms;
using ObjetoTransferencia;
using Negocio;
namespace Apresentacao
{
    public partial class frmFornecedorCadastrar : MetroForm
    {
        public frmFornecedorCadastrar()
        {
            InitializeComponent();
        }

        private void frmFornecedorCadastrar_Load(object sender, EventArgs e)
        {

        }
        private void btnFornecedorSalvar_Click_1(object sender, EventArgs e)
        {
            if (txtNomeFantasiaCadastrar.Text != "" && mskTxtCnpjCadastrar.Text != "")
            {
                DialogResult resp = MetroFramework.MetroMessageBox.Show(this,
                                                                        "\nNOME FANTASIA: " + txtNomeFantasiaCadastrar.Text
                                                                        + "\nCNPJ: " + mskTxtCnpjCadastrar.Text,
                                                                        "CADASTRAR ESSE FORNECEDOR ?",
                                                                        MessageBoxButtons.YesNo,
                                                                        MessageBoxIcon.Information);

                if (resp == DialogResult.Yes)
                {
                    //Ignora os caracteres especiais
                    string CaracterAceitos = "[^a-zA-Z0-9]";
                    string cnpj = Regex.Replace(mskTxtCnpjCadastrar.Text, CaracterAceitos, "");

                    clsFornecedor fornecedor = new clsFornecedor();
                    clsFornecedorNegocio fornecedorNegocio = new clsFornecedorNegocio();

                    fornecedor.NomeFantasia = txtNomeFantasiaCadastrar.Text;
                    fornecedor.Cnpj = cnpj;

                    string retorno = fornecedorNegocio.InserirForncedor(fornecedor);

                    try
                    {
                        int id_Fornecedor = Convert.ToInt32(retorno);
                        MetroFramework.MetroMessageBox.Show(this, "Fornecedor inserido com sucesso. Código: " + id_Fornecedor.ToString(), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult resp2 = MetroFramework.MetroMessageBox.Show(this,
                                                                                "CADASTRAR OUTRO FORNECEDOR ?",
                                                                                "INFORMAÇÃO !",
                                                                                MessageBoxButtons.YesNo,
                                                                                MessageBoxIcon.Information);

                        if (resp2 == DialogResult.Yes)
                        {
                            txtNomeFantasiaCadastrar.Clear();
                            mskTxtCnpjCadastrar.Clear();
                            txtNomeFantasiaCadastrar.Focus();
                        }
                        else
                        {
                            Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir. Detalhe: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nCAMPOS EM BRANCO !\n\nPREENCHA TODOS OS CAMPOS, POR FAVOR !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFornecedorCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFornecedorLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFantasiaCadastrar.Clear();
            mskTxtCnpjCadastrar.Clear();
            txtNomeFantasiaCadastrar.Focus();
        }
    }
}
