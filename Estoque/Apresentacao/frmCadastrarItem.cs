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
    public partial class frmCadastrarItem : MetroForm
    {
        public frmCadastrarItem()
        {
            InitializeComponent();
            
            clsTipoNegocio tipo = new clsTipoNegocio();
            clsFornecedorNegocio fornecedor = new clsFornecedorNegocio();

            cboCategoriaCadastrar.DataSource = tipo.CarregarCategoria();
            cboFornecedorCadastrarItem.DataSource = fornecedor.CarregarFornecedor();
        }

        private void frmCadastrarItem_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clsItem item = new clsItem();
            clsTipo tipo = new clsTipo();
            clsItemNegocio itemNegocio = new clsItemNegocio();

            item.Descricao = txtDescricaoCadastrar.Text;
            int idTipo = ((clsTipo)cboCategoriaCadastrar.SelectedItem).id;
            item.idTipo = idTipo;

            item.Qtde = Convert.ToInt32(txtQtdeCadastrar.Text);
            item.PrecoUnit = Convert.ToDouble(txtPrecoCadastrar.Text);
            
            string retorno = itemNegocio.Inserir(item);
            
            try
            {
                int id_Produto = Convert.ToInt32(retorno);
                MetroFramework.MetroMessageBox.Show(this,"Produto inserido com sucesso. Código: " + id_Produto.ToString(),"INFORMAÇÃO", MessageBoxButtons.OK,MessageBoxIcon.Information);
                //this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("Não foi possivel inserir. Detalhe: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
