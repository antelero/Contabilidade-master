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
using Negocio;
using ObjetoTransferencia;
using MetroFramework.Forms;
namespace Apresentacao
{
    public partial class frmClienteCadastrar : MetroForm
    {
        public frmClienteCadastrar()
        {
            InitializeComponent();
        }

        private void frmClienteCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void btnClienteSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text != "" && mskTxtCnpjCadastrarCliente.Text != "")
            {
                DialogResult resp = MetroFramework.MetroMessageBox.Show(this,
                                                                        "\nNOME DO CLIENTE: " + txtNomeCliente.Text
                                                                        + "\nCNPJ: " + mskTxtCnpjCadastrarCliente.Text,
                                                                        "CADASTRAR ESSE CLIENTE ?",
                                                                        MessageBoxButtons.YesNo,
                                                                        MessageBoxIcon.Information);

                if (resp == DialogResult.Yes)
                {
                    //Ignora os caracteres especiais
                    string CaracterAceitos = "[^a-zA-Z0-9]";
                    string cnpj = Regex.Replace(mskTxtCnpjCadastrarCliente.Text, CaracterAceitos, "");

                    clsFornecedor cliente = new clsFornecedor();
                    clsFornecedorNegocio clienteNegocio = new clsFornecedorNegocio();

                    cliente.NomeFantasia = txtNomeCliente.Text;
                    cliente.Cnpj = cnpj;

                    string retorno = clienteNegocio.InserirCliente(cliente);

                    try
                    {
                        int id_Fornecedor = Convert.ToInt32(retorno);
                        MetroFramework.MetroMessageBox.Show(this, "Cliente inserido com sucesso. Código: " + id_Fornecedor.ToString(), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult resp2 = MetroFramework.MetroMessageBox.Show(this,
                                                                                "CADASTRAR OUTRO CLIENTE ?",
                                                                                "INFORMAÇÃO !",
                                                                                MessageBoxButtons.YesNo,
                                                                                MessageBoxIcon.Information);

                        if (resp2 == DialogResult.Yes)
                        {
                            txtNomeCliente.Clear();
                            mskTxtCnpjCadastrarCliente.Clear();
                            txtNomeCliente.Focus();
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

        private void btnClienteLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            mskTxtCnpjCadastrarCliente.Clear();
            txtNomeCliente.Focus();
        }

        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
