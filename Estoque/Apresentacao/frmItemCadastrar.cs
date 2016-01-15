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
    public partial class frmItemCadastrar : MetroForm
    {
        int nTamanhoAntes = 0;
        public frmItemCadastrar()
        {
            InitializeComponent();
            
            // Instanciando novos objetos das class
            clsTipoNegocio tipo = new clsTipoNegocio(); 
            clsFornecedorNegocio fornecedor = new clsFornecedorNegocio();
            clsEstoqueNegocio Mov = new clsEstoqueNegocio();

            // Carregando os combobox com as informações do Banco de dados
            cboMovCadastrarItem.DataSource = Mov.CarregarMov();
            cboCategoriaCadastrar.DataSource = tipo.CarregarCategoria();
            cboFornecedorCadastrarItem.DataSource = fornecedor.CarregarFornecedor();
        }

        private void frmCadastrarItem_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Instanciando um novo objeto das class
            clsItem item = new clsItem();
            clsItemNegocio itemNegocio = new clsItemNegocio();

            // Criando uma variavel do tipo int
            // Que vai receber o id da opção selecionada
            // Passando esse id para a propriedade
            int idMov = ((clsMovimentacao)cboMovCadastrarItem.SelectedItem).idMovimentacao;
            item.idMovimentacao = idMov;
            
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
                MetroFramework.MetroMessageBox.Show(this,"Produto inserido com sucesso.","INFORMAÇÃO", MessageBoxButtons.OK,MessageBoxIcon.Information);

                DialogResult resp = MetroFramework.MetroMessageBox.Show(this, "DESEJA CONTINUAR ?", "INFORMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resp == DialogResult.Yes)
                {
                    cboMovCadastrarItem.SelectedItem = 0;
                    cboFornecedorCadastrarItem.SelectedItem = 0;
                    cboCategoriaCadastrar.SelectedItem = 0;
                    txtDescricaoCadastrar.Clear();
                    txtPrecoCadastrar.Clear();
                    txtQtdeCadastrar.Clear();
                    cboMovCadastrarItem.Focus();
                }
                else
                {
                    frmTelaControle estoque = new frmTelaControle();
                    estoque.ShowDialog();
                    Close();
                }
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
    }
}
