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
    public partial class frmUsuarioAlterar : MetroForm
    {
        int id;
        public frmUsuarioAlterar(clsPessoa usuario)
        {
            InitializeComponent();

            //Carregando no formulário os dados do usuário que será alterado.
            id = usuario.id;
            txtAlterarNome.Text = usuario.Nome;
            txtAlterarSobreNome.Text = usuario.SobreNome;
            dtAlterarDtNasc.Value = usuario.DataNascimento;
            txtAlterarEmail.Text = usuario.Email;
            txtAlterarSenha.Text = usuario.Senha;
            txtAlterarNivelAcesso.Text = Convert.ToString(usuario.idNivel);
        }

        private void frmUsuarioAlterar_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //Instanciando as classes de Negocio e pessoa
            clsPessoaNegocio pessoaNegocio = new clsPessoaNegocio();
            clsPessoa pessoa = new clsPessoa();

            //Passando novas informaçoes para os atributos da classe pessoa 
            pessoa.id = id;
            pessoa.Nome = txtAlterarNome.Text;
            pessoa.SobreNome = txtAlterarSobreNome.Text;
            pessoa.DataNascimento = dtAlterarDtNasc.Value;
            pessoa.Email = txtAlterarEmail.Text;
            pessoa.Senha = txtAlterarSenha.Text;
            pessoa.idNivel = Convert.ToInt32(txtAlterarNivelAcesso.Text);
            
            //Recebendo o retorno do metodo Alterar da classe Negocio.
            int resp = pessoaNegocio.Alterar(pessoa);

            if (resp == 0)
            {
                MetroFramework.MetroMessageBox.Show(this,
                                                    "",
                                                    "USUÁRIO NÃO " +
                                                    "\nFOI ALTERADO!",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,
                                                    "USUÁRIO ALTERADO " +
                                                    "\nCOM SUCESSO !",
                                                    "",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);

                //Atribuindo ao 'DialogResult' desse form a resposta Yes.
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "OPERAÇÃO DE ALTERAÇÃO FOI CANCELADA COM SUCESSO !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
