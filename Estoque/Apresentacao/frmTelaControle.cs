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
    public partial class frmTelaControle : MetroForm
    {
        string consulta;
        
        public frmTelaControle(int id)
        {
            InitializeComponent();

            if (id == 1)
            {
                btnConfUsuario.Visible = true;
                btnNovoUsuario.Visible = true;
            }
            dtGridViewPrincipal.AutoGenerateColumns = false;
            dtGridViewPEPS.AutoGenerateColumns = false;
            dtGridViewUEPS.AutoGenerateColumns = false;
            dtGridViewCustoMedio.AutoGenerateColumns = false;
            AtualizarGrid();
        }
        private void frmTelaControle_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            AtualizarGridPEPS();
            AtualizarGridUEPS();
            AtualizarGridCustoMedio();

        }
        private void AtualizarGrid()
        {
            clsEstoqueNegocio estoqueNegocio = new clsEstoqueNegocio();
            clsEstoqueColecao estoqueColecao = new clsEstoqueColecao();

            estoqueColecao = estoqueNegocio.CarregarEstoqueDisponivel();

            dtGridViewPrincipal.DataSource = null;

            dtGridViewPrincipal.DataSource = estoqueColecao;
            dtGridViewPrincipal.Update();
            dtGridViewPrincipal.Refresh();
        }
        private void AtualizarGridPEPS()
        {
            clsEstoqueNegocio estoqueNegocioPEPS = new clsEstoqueNegocio();
            clsEstoqueColecao estoqueColecaoPEPS = new clsEstoqueColecao();

            estoqueColecaoPEPS = estoqueNegocioPEPS.CarregarMovi_EstoquePEPS();

            dtGridViewPEPS.DataSource = null;

            dtGridViewPEPS.DataSource = estoqueColecaoPEPS;
            dtGridViewPEPS.Update();
            dtGridViewPEPS.Refresh();
        }
        private void AtualizarGridUEPS()
        {
            clsEstoqueNegocio estoqueNegocioUEPS = new clsEstoqueNegocio();
            clsEstoqueColecao estoqueColecaoUEPS = new clsEstoqueColecao();

            estoqueColecaoUEPS = estoqueNegocioUEPS.CarregarMovi_EstoqueUEPS();

            dtGridViewUEPS.DataSource = null;

            dtGridViewUEPS.DataSource = estoqueColecaoUEPS;

            dtGridViewUEPS.Update();
            dtGridViewUEPS.Refresh();
        }
        private void AtualizarGridCustoMedio()
        {
            clsEstoqueNegocio estoqueNegocioCustoMedio = new clsEstoqueNegocio();
            clsEstoqueColecao estoqueColecaoCustoMedio = new clsEstoqueColecao();

            estoqueColecaoCustoMedio = estoqueNegocioCustoMedio.CarregarMovi_EstoqueCustoMedio();

            dtGridViewCustoMedio.DataSource = null;

            dtGridViewCustoMedio.DataSource = estoqueColecaoCustoMedio;

            dtGridViewCustoMedio.Update();
            dtGridViewCustoMedio.Refresh();
        }
        private void dtGridViewPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Criando um objeto estoque que vai receber dados do GridView
            clsEstoque estoque = dtGridViewPrincipal.SelectedRows[0].DataBoundItem as clsEstoque;

            //Instanciando um novo objeto do frmVendas
            //Passando o objeto estoque como parametro
            frmProdutoVender venda = new frmProdutoVender(estoque);

            //Chamando esse novo objeto venda
            //Passando como resposta 'yes' caso seja feita a venda
            DialogResult resp = venda.ShowDialog();

            if (resp == DialogResult.Yes)
            {
                AtualizarGrid();
                AtualizarGridPEPS();
                AtualizarGridUEPS();
                AtualizarGridCustoMedio();
            }
        }
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            frmProdutoComprar NovoProduto = new frmProdutoComprar();
            DialogResult resp = NovoProduto.ShowDialog();
            if (resp == DialogResult.Yes)
                AtualizarGrid();
        }
        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastrar NovoFornecedor = new frmFornecedorCadastrar();
            DialogResult resp = NovoFornecedor.ShowDialog();
        }
        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            frmCategoriaCadastrar NovaCategoria = new frmCategoriaCadastrar();
            NovaCategoria.ShowDialog();
        }
        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {

        }
        private void txtBuscaEstoquePrincipal_TextChanged(object sender, EventArgs e)
        {
            consulta = txtBuscaEstoquePrincipal.Text;

            clsEstoqueNegocio ENFiltrarBusca = new clsEstoqueNegocio();

            dtGridViewPrincipal.DataSource = ENFiltrarBusca.FiltrarBuscaEstoquePrincipal(consulta, OpcaoBusca());
        }
        private void txtBuscaEstoquePEPS_TextChanged(object sender, EventArgs e)
        {
            consulta = txtBuscaEstoquePEPS.Text;

            clsEstoqueNegocio ENFiltrarBuscaPEPS = new clsEstoqueNegocio();

            dtGridViewPEPS.DataSource = ENFiltrarBuscaPEPS.FiltrarBuscaEstoquePEPS(consulta, OpcaoBusca());
        }
        private void txtBuscaEstoqueUEPS_TextChanged(object sender, EventArgs e)
        {
            consulta = txtBuscaEstoqueUEPS.Text;

            clsEstoqueNegocio ENFiltrarBuscaUEPS = new clsEstoqueNegocio();

            dtGridViewUEPS.DataSource = ENFiltrarBuscaUEPS.FiltrarBuscaEstoqueUEPS(consulta, OpcaoBusca());
        }
        private void txtBuscaEstoqueCustoMedio_TextChanged(object sender, EventArgs e)
        {
            consulta = txtBuscaEstoqueCustoMedio.Text;

            clsEstoqueNegocio ENFiltrarBuscaCM = new clsEstoqueNegocio();

            dtGridViewCustoMedio.DataSource = ENFiltrarBuscaCM.FiltrarBuscaEstoqueCM(consulta, OpcaoBusca());
        }
        private string OpcaoBusca()
        {
            string opcao = "";

            if (rdbDescricao.Checked)
            {
                opcao = "Descrição_Item";
            }
            else
                if (rdbCategoria.Checked)
                {
                    opcao = "Categoria_Item";
                }
                else
                    if (rdbFornecedor.Checked)
                    {
                        opcao = "NomeFantasia";
                    }
                    else
                        if (rdbMovPEPS.Checked)
                        {
                            opcao = "Desc_Mov";
                        }
                        else
                            if (rdbLotePEPS.Checked)
                            {
                                opcao = "NumLote";
                            }
                            else
                                if (rdbDescricaoPEPS.Checked)
                                {
                                    opcao = "Descricao";
                                }
                                else
                                    if (rdbMovUEPS.Checked)
                                    {
                                        opcao = "Desc_Mov";
                                    }
                                    else
                                        if (rdbLoteUEPS.Checked)
                                        {
                                            opcao = "NumLote";
                                        }
                                        else
                                            if (rdbDescricaoUEPS.Checked)
                                            {
                                                opcao = "Descricao";
                                            }
                                            else
                                                if (rdbMovCM.Checked)
                                                {
                                                    opcao = "Desc_Mov";
                                                }
                                                else
                                                    if (rdbLoteCM.Checked)
                                                    {
                                                        opcao = "NumLote";
                                                    }
                                                    else
                                                        if (rdbDescricaoCM.Checked)
                                                        {
                                                            opcao = "Descricao";
                                                        }
            return opcao;
        }
        private void tbpEstoquePrincipal_Enter(object sender, EventArgs e)
        {
            rdbMovPEPS.Checked = false;
            rdbLotePEPS.Checked = false;
            rdbDescricaoPEPS.Checked = false;


            rdbMovUEPS.Checked = false;
            rdbLoteUEPS.Checked = false;
            rdbDescricaoUEPS.Checked = false;


            rdbMovCM.Checked = false;
            rdbLoteCM.Checked = false;
            rdbDescricaoCM.Checked = false;
        }
        private void tbpEstoquePEPS_Enter(object sender, EventArgs e)
        {
            rdbDescricao.Checked = false;
            rdbCategoria.Checked = false;
            rdbFornecedor.Checked = false;

            rdbMovUEPS.Checked = false;
            rdbLoteUEPS.Checked = false;
            rdbDescricaoUEPS.Checked = false;


            rdbMovCM.Checked = false;
            rdbLoteCM.Checked = false;
            rdbDescricaoCM.Checked = false;
        }
        private void tbpEstoqueUEPS_Enter(object sender, EventArgs e)
        {
            rdbDescricao.Checked = false;
            rdbCategoria.Checked = false;
            rdbFornecedor.Checked = false;

            rdbMovPEPS.Checked = false;
            rdbLotePEPS.Checked = false;
            rdbDescricaoPEPS.Checked = false;

            rdbMovCM.Checked = false;
            rdbLoteCM.Checked = false;
            rdbDescricaoCM.Checked = false;
        }
        private void tbpEstoqueCM_Enter(object sender, EventArgs e)
        {
            rdbDescricao.Checked = false;
            rdbCategoria.Checked = false;
            rdbFornecedor.Checked = false;

            rdbMovPEPS.Checked = false;
            rdbLotePEPS.Checked = false;
            rdbDescricaoPEPS.Checked = false;


            rdbMovUEPS.Checked = false;
            rdbLoteUEPS.Checked = false;
            rdbDescricaoUEPS.Checked = false;
        }
        private void btnConfUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuario = new frmUsuarios();
            Usuario.ShowDialog();
        }
        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastrar UC = new frmUsuarioCadastrar();
            UC.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnEmitirRelatorioPEPS_Click(object sender, EventArgs e)
        {
            frmRelatorioPEPS RelatorioPEPS = new frmRelatorioPEPS();
            RelatorioPEPS.Show();
        }
        private void btnEmitirRelatorioUEPS_Click(object sender, EventArgs e)
        {
            frmRelatorioUEPS RelatorioUEPS = new frmRelatorioUEPS();
            RelatorioUEPS.Show();
        }
        private void btnEmitirRelatorioCM_Click(object sender, EventArgs e)
        {
            frmRelatorioCM RelatorioCM = new frmRelatorioCM();
            RelatorioCM.Show();
        }
        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void mstripVenderProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
