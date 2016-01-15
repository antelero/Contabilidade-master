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
    public class clsTipoNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public clsTipoColecao CarregarCategoria()
        {
            try
            {
                clsTipoColecao tipoColecao = new clsTipoColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblTipo");
                
                foreach (DataRow linha in dataTable.Rows)
                {
                    clsTipo t = new clsTipo();
                    
                    t.Descricao = Convert.ToString(linha["Descricao"]);
                    t.id = Convert.ToInt32(linha["id"]);
                    tipoColecao.Add(t);
                }
                
                return tipoColecao;

            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public string CadastrarCategoria(clsTipo desc)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Descricao", desc.Descricao);

                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCategoriaCadastrar").ToString();

                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
