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
    public partial class frmProdutoVender : MetroForm
    {
        frmTelaControle estoque = new frmTelaControle(0);
        int resp=0;
        //int Venda = 0;
        public frmProdutoVender(clsEstoque estoque)
        {
            InitializeComponent();

            clsFornecedorNegocio fn = new clsFornecedorNegocio();

            txtDescMovVenda.Text = "Venda";
            txtDescricaoVenda.Text = estoque.DescricaoItem;
            txtQtdeVenda.Text = estoque.Qtde.ToString();
            txtCategoriaVenda.Text = estoque.CategoriaItem.ToString();
            dtEntradaVenda.Value = estoque.DataEntrada;
            
            cboCliente.DataSource = fn.CarregarCliente();
        }
        private void frmProdutoVender_Load(object sender, EventArgs e)
        {
            clsFornecedorNegocio fn = new clsFornecedorNegocio();
            cboCliente.DataSource = fn.CarregarCliente();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int qtde = Convert.ToInt32(txtQtdeVenda.Text);

            EfetuarVenda(qtde);

            MetroFramework.MetroMessageBox.Show(this, "\n\n A VENDA FOI EFETUADA COM SUCESSO ! .", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.Yes;

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        public int EfetuarVenda(int qtde)
        {
            clsEstoqueNegocio estoquenegocio = new clsEstoqueNegocio();
            clsEstoqueColecao estoquecolecao = new clsEstoqueColecao();
            clsEstoque estoque = new clsEstoque();

            //tira do PEPS
            estoquecolecao = estoquenegocio.CarregarProdutoAntigo(txtDescricaoVenda.Text);

            estoque.NumLote = estoquecolecao[0].NumLote;
            estoque.Qtde = qtde;

            resp = estoquenegocio.AlterarPEPS(estoque);

            return resp;
        }

        private void lblCadastrarNovoFornecedor_Click(object sender, EventArgs e)
        {
            frmClienteCadastrar CC = new frmClienteCadastrar();
            CC.ShowDialog();

            clsFornecedorNegocio fn = new clsFornecedorNegocio();
            cboCliente.DataSource = fn.CarregarCliente();
        }
    }
}
