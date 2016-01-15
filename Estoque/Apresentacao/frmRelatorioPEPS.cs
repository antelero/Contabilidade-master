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
namespace Apresentacao
{
    public partial class frmRelatorioPEPS : MetroForm
    {
        public frmRelatorioPEPS()
        {
            InitializeComponent();
        }

        private void frmRelatorioPEPS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetControleEstoque.uvwEstoquePEPSCarregar' table. You can move, or remove it, as needed.
            this.uvwEstoquePEPSCarregarTableAdapter.Fill(this.DataSetControleEstoque.uvwEstoquePEPSCarregar);
            // TODO: This line of code loads data into the 'DataSetControleEstoque.uvwEstoqueUEPSCarregar' table. You can move, or remove it, as needed.
            this.uvwEstoqueUEPSCarregarTableAdapter.Fill(this.DataSetControleEstoque.uvwEstoqueUEPSCarregar);
            // TODO: This line of code loads data into the 'DataSetControleEstoque.uvwEstoqueCustoMedioCarregar' table. You can move, or remove it, as needed.
            this.uvwEstoqueCustoMedioCarregarTableAdapter.Fill(this.DataSetControleEstoque.uvwEstoqueCustoMedioCarregar);

            this.reportViewer1.RefreshReport();
        }
    }
}
