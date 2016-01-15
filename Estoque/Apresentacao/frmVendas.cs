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
    public partial class frmVendas : MetroForm
    {
        public frmVendas(clsEstoque estoque)
        {
            InitializeComponent();

            txtDescMovVenda.Text = "Venda";
            txtDescricaoVenda.Text = estoque.DescricaoItem;
            txtPrecoVenda.Text = estoque.PrecoUnit.ToString();
            txtQtdeVenda.Text = estoque.Qtde.ToString();
            txtCategoriaVenda.Text = estoque.CategoriaItem.ToString();
            dtEntradaVenda.Value = estoque.DataEntrada;
        }
    }
}
