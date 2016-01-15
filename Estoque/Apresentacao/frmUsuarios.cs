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
    public partial class frmUsuarios : MetroForm
    {
        public frmUsuarios()
        {
            InitializeComponent();

            Refresh();

            dtGridViewUsuario.AutoGenerateColumns = false;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            AtualizarGridUsuario();
        }
        private void AtualizarGridUsuario()
        {
            clsPessoaNegocio PN = new clsPessoaNegocio();
            clsPessoaColecao PC = new clsPessoaColecao();

            PC = PN.CarregarUsuarios();

            dtGridViewUsuario.DataSource = null;

            dtGridViewUsuario.DataSource = PC;
            dtGridViewUsuario.Update();
            dtGridViewUsuario.Refresh();
        }

        private void dtGridViewUsuario_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            clsPessoa pessoa = dtGridViewUsuario.SelectedRows[0].DataBoundItem as clsPessoa;

            DialogResult resp = MetroFramework.MetroMessageBox.Show(this,
                                                  "\nNOME: " + pessoa.Nome
                                                + "\nSOBRENOME: " + pessoa.SobreNome
                                                + "\nDATANASCIMENTO: " + pessoa.DataNascimento
                                                + "\nEMAIL: " + pessoa.Email,
                                                "DESEJA REALMENTE EXCLUIR ESSE USUÁRIO ?",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resp == DialogResult.Yes)
            {
                clsPessoaNegocio PN = new clsPessoaNegocio();
                
                int retorno = PN.Excluir(pessoa);

                if (retorno > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, 
                                                  "\nNOME: " + pessoa.Nome
                                                + "\nSOBRENOME: " + pessoa.SobreNome
                                                + "\nDATANASCIMENTO: " + pessoa.DataNascimento
                                                + "\nEMAIL: " + pessoa.Email,
                                                  "USUÁRIO EXCLUIDO COM SUCESSO !",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridUsuario();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, 
                                              "\nNOME: " + pessoa.Nome
                                            + "\nSOBRENOME: " + pessoa.SobreNome
                                            + "\nDATANASCIMENTO: " + pessoa.DataNascimento
                                            + "\nEMAIL: " + pessoa.Email,
                                            "NÃO FOI POSSIVEL EXCLUIR O USUÁRIO !",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelarExclusao_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            clsPessoa pessoa = dtGridViewUsuario.SelectedRows[0].DataBoundItem as clsPessoa;

            DialogResult resp = MetroFramework.MetroMessageBox.Show(this,
                                                                    "",
                                                                    "DESEJA REALMENTE ALTERAR ESSE USUÁRIO ?",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Information);
            //Se 'resp' for 'yes' o processo de alteração e iniciado.
            //Senão é apresentado uma mensagem.
            if (resp == DialogResult.Yes)
            {
                //Instanciando o form para poder ser chamado por outro form.
                //Passando 'pessoa' do tipo 'clsPessoa' como parametro.
                frmUsuarioAlterar usuarioAlterar = new frmUsuarioAlterar(pessoa);

                //Chamando o formulario instanciado.
                //E passando uma respota para a variável 'resultado'.
                //Se 'resultado' for 'yes' o gridview e atualizado.
                DialogResult resultado = usuarioAlterar.ShowDialog();
                if (resultado == DialogResult.Yes)
                {
                    AtualizarGridUsuario();
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "OPERAÇÃO DE ALTERAÇÃO FOI CANCELADA COM SUCESSO !","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
