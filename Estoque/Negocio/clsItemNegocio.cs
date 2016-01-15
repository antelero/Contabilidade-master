using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using AcessoBancoDados;
using ObjetoTransferencia;
namespace Negocio
{
    public class clsItemNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(clsItem item)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@idMovimentacao", item.idMovimentacao);
                acessoDadosSqlServer.AdicionarParametros("@Descricao", item.Descricao);
                acessoDadosSqlServer.AdicionarParametros("@idTipo", item.idTipo);
                acessoDadosSqlServer.AdicionarParametros("@Qtde", item.Qtde);
                acessoDadosSqlServer.AdicionarParametros("@PrecoUnit", item.PrecoUnit);
                acessoDadosSqlServer.AdicionarParametros("@idFornecedor", item.idFornecedor);
                //acessoDadosSqlServer.AdicionarParametros("@DataEntrada", item.DataEntrada);

                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoComprar").ToString();

                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public clsItemColecao CarregarProdutos()
        {
            try
            {
                clsItemColecao itemColecao = new clsItemColecao();
                
                acessoDadosSqlServer.LimparParametros();

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM uvwConsultarDescricaoCategoria");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsItem p = new clsItem();
                    
                    p.Descricao = Convert.ToString(linha["Bebida"]);

                    itemColecao.Add(p);
                }
                return itemColecao;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        
    }
}
