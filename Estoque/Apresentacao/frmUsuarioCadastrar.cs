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
    public partial class frmUsuarioCadastrar : MetroForm
    {
        
        string retorno;
        public frmUsuarioCadastrar()
        {
            InitializeComponent();
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            txtNome.Text = "NOME";
            txtSobreNome.Text = "SOBRENOME";
            txtEmail.Text = "E-MAIL";
            txtSenha.Text = "SENHA";
            txtConfirmarSenhar.Text = "CONFIRMAR SENHA";
        }
        private void txtNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtSobreNome_Click(object sender, EventArgs e)
        {
            txtSobreNome.Text = "";
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        private void txtConfirmarSenhar_Click(object sender, EventArgs e)
        {
            txtConfirmarSenhar.Text = "";
            txtConfirmarSenhar.PasswordChar = '*';
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void txtSobreNome_Enter(object sender, EventArgs e)
        {
            txtSobreNome.Text = "";
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
        }

        private void txtConfirmarSenhar_Enter(object sender, EventArgs e)
        {
            txtConfirmarSenhar.Text = "";
            txtConfirmarSenhar.PasswordChar = '*';
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtSobreNome.Text != "" && txtEmail.Text != "")
            {
                if (txtSenha.Text != "" && txtConfirmarSenhar.Text != "")
                {
                    if (txtSenha.Text.Equals(txtConfirmarSenhar.Text))
                    {
                        try
                        {
                            clsPessoa pessoa = new clsPessoa();

                            pessoa.Nome = txtNome.Text;
                            pessoa.SobreNome = txtSobreNome.Text;
                            pessoa.DataNascimento = dtDataNascimento.Value;
                            pessoa.Email = txtEmail.Text;
                            pessoa.Senha = txtSenha.Text;
                            pessoa.idNivel = 2;

                            clsPessoaNegocio pessoaNegocio = new clsPessoaNegocio();
                            retorno = pessoaNegocio.Inserir(pessoa);

                            if (retorno.Length == 1)
                            {
                                int id_cliente = Convert.ToInt32(retorno);
                                MetroFramework.MetroMessageBox.Show(this,
                                                                    "\n\nUSUÁRIO CADASTRADO COM SUCESSO.\n\n\n" +
                                                                    "SEJA BEM-VINDO(A): " + pessoa.Nome.ToString() + " " + pessoa.SobreNome.ToString(), "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Close();
                                Dispose();
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Não foi possivel cadastrar o novo usuário. Detalhe: " + retorno, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception exception)
                        {
                            throw new Exception("Não foi possivel inserir. Detalhe: " + exception.Message);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "As senhas estão diferentes !", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\nCampos em Branco !\n\nPreencha todos os campos, Por favor !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nCampos em Branco !\n\nPreencha todos os campos, Por favor !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
