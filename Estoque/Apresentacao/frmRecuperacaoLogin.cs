using System;
using System.Windows.Forms;


using ObjetoTransferencia;
using Negocio;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Net.Mail;
namespace Apresentacao
{
    public partial class frmRecuperacaoLogin : MetroForm
    {
        public frmRecuperacaoLogin()
        {
            InitializeComponent();
        }

        private void frmRecuperacaoLogin_Load(object sender, EventArgs e)
        {
            txtRecuperarSenha.Text = "DIGITE O E-MAIL CADASTRADO";
        }

        private void txtRecuperarSenha_Click(object sender, EventArgs e)
        {
            txtRecuperarSenha.Text = "";
        }

        private void btnEnviarEmail_Click_1(object sender, EventArgs e)
        {
            if (txtRecuperarSenha.Text != "")
            {
                //Instanciando novos objtos da Class pessoaColeção e emailNegocio
                clsPessoaColecao pessoaColecao = new clsPessoaColecao();
                clsEmailNegocio emailNegocio = new clsEmailNegocio();

                //O novo objeto do Tipo clsPessoaColecao
                //esta recebendo do objeto do Tipo clsEmailNegocio
                //que esta chamando o método 'EmailSenha' com o parametro da 'txtRecuperarSenha.text'
                pessoaColecao = emailNegocio.EmailSenha(txtRecuperarSenha.Text);

                if (pessoaColecao[0].id != 0)
                {

                    //Declarando duas variaveis que vão receber
                    //Nome e Senha que esta vinculado
                    //com o Email informado no 'txtRecuperarSenha.txt'
                    string nome = pessoaColecao[0].Nome;
                    string senha = pessoaColecao[0].Senha;

                    emailNegocio.EnviarEmail(txtRecuperarSenha.Text, nome, senha);

                    MetroFramework.MetroMessageBox.Show(this,
                                                        "\n\nSeu usuário e senha foram enviados para o e-mail cadastrado!",
                                                        "E-MAIL ENVIADO COM SUCESSO",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this,
                                                        "\n\nSeu usuário e senha não foram encontrados !",
                                                        "ATENÇÃO",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\nCAMPOS EM BRANCO !\n\nPREENCHA TODOS OS CAMPOS, POR FAVOR !", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
//AQUI NESSA TELA PRECISA VALIDAR SE O E-MAIL INFORMADO ESTA CADASTRADO OU NÃO