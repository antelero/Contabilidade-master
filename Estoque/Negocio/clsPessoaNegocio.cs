using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Net;
using System.Net.Mail;
using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocio
{
    public class clsPessoaNegocio
    {
        clsPessoaColecao PC = new clsPessoaColecao();
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(clsPessoa pessoa)
        {
            try
            {
                //limpar parametros.
                acessoDadosSqlServer.LimparParametros();

                //adicionar um cliente e seus atributos.
                acessoDadosSqlServer.AdicionarParametros("@Nome", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@SobreNome", pessoa.SobreNome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", pessoa.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Email", pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("@Senha", pessoa.Senha);
                acessoDadosSqlServer.AdicionarParametros("@idNivel", pessoa.idNivel);

                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioCadastrar").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }
        public string Consultar(clsPessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Nome", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("@Senha", pessoa.Senha);
                string id_Cliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioValidar").ToString();

                return id_Cliente;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }
        public string AlterarAcesso(String SenhaAtual, String NovaSenha)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@SenhaAtual", SenhaAtual);
                acessoDadosSqlServer.AdicionarParametros("@NovaSenha", NovaSenha);

                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarAcesso").ToString();

                return retorno;
            }
            catch (Exception exception)
            {
                
                return exception.Message;
            }
        }
        public clsPessoaColecao CarregarUsuarios()
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                DataTable dt =  acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblUsuario");

                foreach (DataRow linha in dt.Rows)
                {
                    clsPessoa P = new clsPessoa();

                    P.id = Convert.ToInt16(linha["idUsuario"]);
                    P.Nome = Convert.ToString(linha["Nome"]);
                    P.SobreNome = Convert.ToString(linha["SobreNome"]);
                    P.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    P.Email = Convert.ToString(linha["Email"]);
                    P.Senha = Convert.ToString(linha["Senha"]);
                    P.idNivel = Convert.ToInt16(linha["idNivel"]);

                    PC.Add(P);
                }

                return PC;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }

        public int Excluir(clsPessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("idUsuario", pessoa.id);
                //acessoDadosSqlServer.AdicionarParametros("SenhaAdmin", pessoa.Senha);

                int resp = Convert.ToInt16(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioExcluir"));

                return resp;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int Alterar(clsPessoa pessoa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("idUsuario", pessoa.id);
                acessoDadosSqlServer.AdicionarParametros("Nome", pessoa.Nome);
                acessoDadosSqlServer.AdicionarParametros("SobreNome", pessoa.SobreNome);
                acessoDadosSqlServer.AdicionarParametros("DataNascimento", pessoa.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("Email", pessoa.Email);
                acessoDadosSqlServer.AdicionarParametros("Senha", pessoa.Senha);
                acessoDadosSqlServer.AdicionarParametros("NivelAcesso", pessoa.idNivel);

                int resp = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspUsuarioAlterar"));

                return resp;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
