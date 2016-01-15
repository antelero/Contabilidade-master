using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


using System.Diagnostics;
using System.Net.Mail;
using ObjetoTransferencia;
using AcessoBancoDados;
namespace Negocio
{
    public class clsEmailNegocio
    {
        clsPessoaColecao DadosAcessoColecao = new clsPessoaColecao();
        clsPessoa DadosAcesso = new clsPessoa();
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public clsPessoaColecao EmailSenha(string _email)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Email", _email);

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEmailVerificar");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsPessoa DadosAcesso = new clsPessoa();

                    DadosAcesso.Nome = Convert.ToString(linha["Nome"]);
                    DadosAcesso.Senha = Convert.ToString(linha["Senha"]);
                    DadosAcesso.id = 1;
                    DadosAcessoColecao.Add(DadosAcesso);
                }

                return DadosAcessoColecao;
            }
            catch (Exception)
            {
                DadosAcesso.id = 0;
                DadosAcessoColecao.Add(DadosAcesso);
                return DadosAcessoColecao;
            }
        }

        public void EnviarEmail(string _email, string _nome, string _senha)
        {

            MailMessage Email = new MailMessage();
            Email.To.Add(new MailAddress(_email)); // Email de destino
            Email.From = new MailAddress("marcelo_denis@outlook.com");// Email de remetente
            Email.Subject = "RECUPERAÇÃO DE SENHA"; // Assunto/Titulo do Email
            Email.Body = "LEMBRANDO SEU USUÁRIO E SENHA !\n\n" +
                         "USUÁRIO: " + _nome + "\n" +
                         "SENHA: " + _senha; // Corpo do Email


            // Instanciando um novo objeto SmtpClient como cliente
            // Servidor e Porta
            SmtpClient cliente = new SmtpClient("smtp.live.com", 587);
            using (cliente)
            {
                string password = "MARCELO03DENIS";
                // Os dados de quem esta enviando o Email
                cliente.Credentials = new System.Net.NetworkCredential(_email, password);
                cliente.EnableSsl = true;
                cliente.Send(Email);
            }
        }
    }
}
