using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using ObjetoTransferencia;
using AcessoBancoDados;
namespace Negocio
{
    public class clsFornecedorNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public clsFornecedorColecao CarregarFornecedor()
        {
            try
            {
                clsFornecedorColecao fornecedorColecao = new clsFornecedorColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblFornecedor");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsFornecedor f = new clsFornecedor();

                    f.id = Convert.ToInt32(linha["id"]);
                    f.NomeFantasia = Convert.ToString(linha["NomeFantasia"]);
                    f.Cnpj = Convert.ToString(linha["Cnpj"]);

                    fornecedorColecao.Add(f);
                }

                return fornecedorColecao;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public string InserirForncedor(clsFornecedor fornecedor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@NomeFantasia", fornecedor.NomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@Cnpj", fornecedor.Cnpj);

                string idFornecedor = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorInserir").ToString();

                return idFornecedor;
            }
            catch (Exception exception)
            {
                
                return exception.Message;
            }
        }

        public string InserirCliente(clsFornecedor Cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeFantasia", Cliente.NomeFantasia);
                acessoDadosSqlServer.AdicionarParametros("@Cnpj", Cliente.Cnpj);

                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return idCliente;
            }
            catch (Exception exception)
            {
                
                return exception.Message;
            }
        }
        
        public clsFornecedorColecao CarregarCliente()
        {
            try
            {
                clsFornecedorColecao cliente = new clsFornecedorColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblCliente");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsFornecedor c = new clsFornecedor();

                    c.id = Convert.ToInt32(linha["id"]);
                    c.NomeFantasia = Convert.ToString(linha["NomeCliente"]);
                    c.Cnpj = Convert.ToString(linha["Cnpj"]);

                    cliente.Add(c);
                }

                return cliente;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
