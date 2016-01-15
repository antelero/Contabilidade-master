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
    public partial class frmCadastrarUsuario : MetroForm
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            clsPessoa pessoa = new clsPessoa();

            pessoa.Nome = txtNome.Text;
            pessoa.SobreNome = txtSobreNome.Text;
            pessoa.DataNascimento = dtDataNascimento.Value;
            pessoa.Email = txtEmail.Text;
            pessoa.Senha = txtSenha.Text;
            pessoa.idNivel = 1;

            clsPessoaNegocio pessoaNegocio = new clsPessoaNegocio();
            string retorno = pessoaNegocio.Inserir(pessoa);

            try
            {
                int id_cliente = Convert.ToInt32(retorno);
                MetroFramework.MetroMessageBox.Show(this, "Usuario inserido com sucesso. Código: " + id_cliente.ToString(), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MetroFramework.MetroMessageBox.Show(this,"Não foi possivel inserir. Detalhe: " + retorno, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }

        }
    }
}
