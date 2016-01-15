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

using ObjetoTransferencia;
using Negocio;

namespace Apresentacao
{
    public partial class frmProdutoComprar : MetroForm
    {
        //int nTamanhoAntes = 0;
        public frmProdutoComprar()
        {
            InitializeComponent();
            
            // Instanciando novos objetos das class
            clsTipoNegocio tipo = new clsTipoNegocio();
            clsFornecedorNegocio fornecedor = new clsFornecedorNegocio();

            // Carregando os combobox com as informações do Banco de dados
            cboCategoriaCadastrar.DataSource = tipo.CarregarCategoria();
            cboFornecedorCadastrarItem.DataSource = fornecedor.CarregarFornecedor();
        }

        private void frmCadastrarItem_Load(object sender, EventArgs e)
        {
            txtMovCompraProduto.Text = "COMPRA";
            
            // Instanciando novos objetos das class
            clsTipoNegocio tipo = new clsTipoNegocio();
            clsFornecedorNegocio fornecedor = new clsFornecedorNegocio();
            clsEstoqueNegocio Mov = new clsEstoqueNegocio();

            // Carregando os combobox com as informações do Banco de dados
            cboCategoriaCadastrar.DataSource = tipo.CarregarCategoria();
            cboFornecedorCadastrarItem.DataSource = fornecedor.CarregarFornecedor();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtMovCompraProduto.Text != "" && txtDescricaoCadastrar.Text != "" && txtPrecoCadastrar.Text != "")
            {
                if (txtQtdeCadastrar.Text != "" && cboCategoriaCadastrar.Text != "" && cboFornecedorCadastrarItem.Text != "")
	            {
                    // Instanciando um novo objeto das class
                    clsItem item = new clsItem();
                    clsItemNegocio itemNegocio = new clsItemNegocio();

                    // Criando uma variavel do tipo int
                    // Que vai receber o id da opção selecionada
                    // Passando esse id para a propriedade

                    item.idMovimentacao = 1;

                    int idTipo = ((clsTipo)cboCategoriaCadastrar.SelectedItem).id;
                    item.idTipo = idTipo;

                    int idFornecedor = ((clsFornecedor)cboFornecedorCadastrarItem.SelectedItem).id;
                    item.idFornecedor = idFornecedor;

                    item.Descricao = txtDescricaoCadastrar.Text;
                    item.Qtde = Convert.ToInt32(txtQtdeCadastrar.Text);
                    item.PrecoUnit = Convert.ToDouble(txtPrecoCadastrar.Text);

                    string retorno = itemNegocio.Inserir(item);

                    try
                    {
                        int id_Produto = Convert.ToInt32(retorno);
                        MetroFramework.MetroMessageBox.Show(this, "Produto inserido com sucesso.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult resp = MetroFramework.MetroMessageBox.Show(this, "DESEJA CONTINUAR ?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (resp == DialogResult.Yes)
                        {
                            //cboMovCadastrarItem.SelectedItem = 0;
                            cboFornecedorCadastrarItem.SelectedItem = 0;
                            cboCategoriaCadastrar.SelectedItem = 0;
                            txtDescricaoCadastrar.Clear();
                            txtPrecoCadastrar.Clear();
                            txtQtdeCadastrar.Clear();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.Yes;
                            Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel inserir. Detalhe: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //this.DialogResult = DialogResult.No;
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\nCAMPOS EM BRANCO !\n\nPREENCHA TODOS OS CAMPOS, POR FAVOR !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nCAMPOS EM BRANCO !\n\nPREENCHA TODOS OS CAMPOS, POR FAVOR !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricaoCadastrar.Clear();
            txtQtdeCadastrar.Clear();
            txtPrecoCadastrar.Clear();
            txtDescricaoCadastrar.Focus();
        }
        private void txtPrecoCadastrar_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoCadastrar);
        }

        // Método dinamico para valores monetarios
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            n = txt.Text.Replace(",", "").Replace(".", "");

            if (n.Equals(""))
                n = "";
            n = n.PadLeft(3, '0');

            if (n.Length > 3 & n.Substring(0, 1) == "0")
                n = n.Substring(1, n.Length - 1);
            v = Convert.ToDouble(n) / 100;
            txt.Text = string.Format("{0:N}", v);
            txt.SelectionStart = txt.Text.Length;
        }

        private void lblCadastrarNovoFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastrar NovoFornecedor = new frmFornecedorCadastrar();
            NovoFornecedor.ShowDialog();

            clsFornecedorNegocio fornecedor = new clsFornecedorNegocio();
            cboFornecedorCadastrarItem.DataSource = fornecedor.CarregarFornecedor();
        }

        private void lblCadastrarNovaCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaCadastrar NovaCategoria = new frmCategoriaCadastrar();
            NovaCategoria.ShowDialog();

            clsTipoNegocio tipo = new clsTipoNegocio();
            cboCategoriaCadastrar.DataSource = tipo.CarregarCategoria();
        }
    }
}
