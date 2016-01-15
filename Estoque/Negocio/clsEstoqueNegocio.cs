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
    public class clsEstoqueNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public clsEstoqueColecao CarregarEstoque()
        {
            try
            {
                clsEstoqueColecao estoqueColecao = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspEstoqueCarregar");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);
                    e.NumLote = Convert.ToInt32(linha["NumLote"]);
                    e.DescricaoItem = Convert.ToString(linha["DescriçãoItem"]);
                    e.CategoriaItem = Convert.ToString(linha["CategoriaItem"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde"]);
                    e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
                    e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    e.NomeFantasia = Convert.ToString(linha["NomeFantasia"]);

                    estoqueColecao.Add(e);
                }
                return estoqueColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }
        public clsEstoqueColecao FiltrarBuscaEstoquePrincipal(String _parametro, String _NomeColuna)
        {
            try
            {
                clsEstoqueColecao estoqueColecao = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Parametro", _parametro);
                acessoDadosSqlServer.AdicionarParametros("@Coluna", _NomeColuna);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFazerBuscaEstoquePrincipal");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.DescricaoItem = Convert.ToString(linha["Descrição_Item"]);
                    e.CategoriaItem = Convert.ToString(linha["Categoria_Item"]);
                    e.NomeFantasia = Convert.ToString(linha["NomeFantasia"]);
                    e.DataEntrada = Convert.ToDateTime(linha["Menor_Data_Entrada"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde_Disponivel"]);

                    estoqueColecao.Add(e);
                }
                return estoqueColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }
        public clsEstoqueColecao FiltrarBuscaEstoquePEPS(String _parametro, String _NomeColuna)
        {
            try
            {
                clsEstoqueColecao estoqueColecao = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Parametro", _parametro);
                acessoDadosSqlServer.AdicionarParametros("@Coluna", _NomeColuna);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFazerBuscaEstoquePEPS");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);
                    e.NumLote = Convert.ToInt32(linha["NumLote"]);
                    e.DescricaoItem = Convert.ToString(linha["Descricao"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde"]);
                    e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
                    e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    e.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    e.SubTotal = Convert.ToDouble(linha["SubTotal"]);

                    estoqueColecao.Add(e);
                }
                return estoqueColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }
        public clsEstoqueColecao FiltrarBuscaEstoqueUEPS(String _parametro, String _NomeColuna)
        {
            try
            {
                clsEstoqueColecao estoqueColecao = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Parametro", _parametro);
                acessoDadosSqlServer.AdicionarParametros("@Coluna", _NomeColuna);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFazerBuscaEstoqueUEPS");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);
                    e.NumLote = Convert.ToInt32(linha["NumLote"]);
                    e.DescricaoItem = Convert.ToString(linha["Descricao"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde"]);
                    e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
                    e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    e.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    e.SubTotal = Convert.ToDouble(linha["SubTotal"]);

                    estoqueColecao.Add(e);
                }
                return estoqueColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }
        public clsEstoqueColecao FiltrarBuscaEstoqueCM(String _parametro, String _NomeColuna)
        {
            try
            {
                clsEstoqueColecao estoqueColecao = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Parametro", _parametro);
                acessoDadosSqlServer.AdicionarParametros("@Coluna", _NomeColuna);
                DataTable dataTable = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFazerBuscaEstoqueCustoMedio");

                foreach (DataRow linha in dataTable.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);
                    e.NumLote = Convert.ToInt32(linha["NumLote"]);
                    e.DescricaoItem = Convert.ToString(linha["Descricao"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde"]);
                    e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
                    e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    e.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    e.SubTotal = Convert.ToDouble(linha["SubTotal"]);

                    estoqueColecao.Add(e);
                }
                return estoqueColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }

        public clsMovimentacaoColecao CarregarMov()
        {
            try
            {
                clsMovimentacaoColecao MovColecao = new clsMovimentacaoColecao();
                
                acessoDadosSqlServer.LimparParametros();

                DataTable datatable = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblMovimentação");

                foreach (DataRow linha in datatable.Rows)
                {
                    clsMovimentacao m = new clsMovimentacao();

                    m.idMovimentacao = Convert.ToInt32(linha["idMovimentacao"]);
                    m.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);

                    MovColecao.Add(m);
                }

                return MovColecao;
            }

            catch (Exception)
            {
                
                throw;
            }
        }
        public clsEstoqueColecao CarregarMovi_EstoquePEPS()
        {
            try
            {
                clsEstoqueColecao MovEst = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dt = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM uvwEstoquePEPSCarregar ORDER BY DataEntrada, NumLote");

                foreach (DataRow linha in dt.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);
                    e.NumLote = Convert.ToInt32(linha["NumLote"]);
                    e.DescricaoItem = Convert.ToString(linha["Descricao"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde"]);
                    e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
                    e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    e.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    e.SubTotal = Convert.ToDouble(linha["SubTotal"]);
                    e.ICMS = Convert.ToDouble(linha["ICMS"]);
                    e.Total = Convert.ToDouble(linha["Total"]);

                    MovEst.Add(e);
                }

                return MovEst;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }

        public clsEstoqueColecao CarregarMovi_EstoqueUEPS()
        {
            try
            {
                clsEstoqueColecao MovEst = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dt = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM uvwEstoqueUEPSCarregar ORDER BY DataEntrada, NumLote");

                foreach (DataRow linha in dt.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);
                    e.NumLote = Convert.ToInt32(linha["NumLote"]);
                    e.DescricaoItem = Convert.ToString(linha["Descricao"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde"]);
                    e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
                    e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    e.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    e.SubTotal = Convert.ToDouble(linha["SubTotal"]);
                    e.ICMS = Convert.ToDouble(linha["ICMS"]);
                    e.Total = Convert.ToDouble(linha["Total"]);
                    MovEst.Add(e);
                }

                return MovEst;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }

        public clsEstoqueColecao CarregarMovi_EstoqueCustoMedio()
        {
            try
            {
                clsEstoqueColecao MovEst = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable dt = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM uvwEstoqueCustoMedioCarregar ORDER BY DataEntrada, NumLote");

                foreach (DataRow linha in dt.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.Desc_Mov = Convert.ToString(linha["Desc_Mov"]);
                    e.NumLote = Convert.ToInt32(linha["NumLote"]);
                    e.DescricaoItem = Convert.ToString(linha["Descricao"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde"]);
                    e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
                    e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);
                    e.DataSaida = Convert.ToDateTime(linha["DataSaida"]);
                    e.SubTotal = Convert.ToDouble(linha["SubTotal"]);
                    e.ICMS = Convert.ToDouble(linha["ICMS"]);
                    e.Total = Convert.ToDouble(linha["Total"]);

                    MovEst.Add(e);
                }

                return MovEst;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }
        public clsEstoqueColecao CarregarEstoqueDisponivel()
        {
            try
            {
                clsEstoqueColecao estoqueDisponivel = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                DataTable datatable = acessoDadosSqlServer.ExecutarConsulta(CommandType.Text, "SELECT * FROM uvwDescricaoCategoriaQtde");

                foreach (DataRow linha in datatable.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.DescricaoItem = Convert.ToString(linha["Descrição_Item"]);
                    e.CategoriaItem = Convert.ToString(linha["Categoria_Item"]);
                    e.DataEntrada = Convert.ToDateTime(linha["Menor_Data_Entrada"]);
                    //e.DataSaida = Convert.ToDateTime(linha["Maior_Data_Entrada"]);
                    e.Qtde = Convert.ToInt32(linha["Qtde_Disponivel"]);
                    //e.PrecoUnit = Convert.ToDouble(linha["Media_Preco"]);

                    estoqueDisponivel.Add(e);
                }
                return estoqueDisponivel;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }

        public clsEstoqueColecao CarregarProdutoAntigo(string Desc)
        {
            try
            {
                clsEstoqueColecao ProdutoAntigo = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Desc", Desc);

                DataTable dt = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarregaProdutoAntigo");
                
                foreach (DataRow linha in dt.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.NumLote = Convert.ToInt32(linha["NumLote"]); 

                    ProdutoAntigo.Add(e);
                }

                return ProdutoAntigo;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }
        public clsEstoqueColecao CarregarProdutoNovo(string Desc)
        {
            try
            {
                clsEstoqueColecao ProdutoAntigo = new clsEstoqueColecao();

                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Desc", Desc);

                DataTable dt = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarregaProdutoNovo");

                foreach (DataRow linha in dt.Rows)
                {
                    clsEstoque e = new clsEstoque();

                    e.NumLote = Convert.ToInt32(linha["NumLote"]);

                    ProdutoAntigo.Add(e);
                }

                return ProdutoAntigo;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
            }
        }

        //public clsEstoqueColecao CarregarProdutoNovo(string Desc)
        //{
        //    try
        //    {
        //        clsEstoqueColecao ProdutoNovo = new clsEstoqueColecao();

        //        acessoDadosSqlServer.LimparParametros();

        //        acessoDadosSqlServer.AdicionarParametros("@Desc", Desc);

        //        DataTable dt = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspCarregaProdutoNovo");

        //        foreach (DataRow linha in dt.Rows)
        //        {
        //            clsEstoque e = new clsEstoque();

        //            e.NumLote = Convert.ToInt32(linha["NumLote"]);
        //            e.DescricaoItem = Convert.ToString(linha["Descricao"]);
        //            e.Qtde = Convert.ToInt32(linha["Qtde"]);
        //            e.PrecoUnit = Convert.ToDouble(linha["PrecoUnit"]);
        //            e.DataEntrada = Convert.ToDateTime(linha["DataEntrada"]);

        //            ProdutoNovo.Add(e);
        //        }

        //        return ProdutoNovo;
        //    }
        //    catch (Exception exception)
        //    {
        //        throw new Exception("Não foi possivel carregar o estoque. Detalhe: " + exception.Message);
        //    }
        //}
        public int AlterarPEPS(clsEstoque estoque)
        {
            
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NumLote", estoque.NumLote);
                acessoDadosSqlServer.AdicionarParametros("Qtde", estoque.Qtde);

                int idProduto = Convert.ToInt32(acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTesteVendaPEPS"));
                
                return idProduto;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel alterar o registro. Detalhe: " + exception.Message);
            }
        }
        public void AlterarUEPS(clsEstoque estoque)
        {

            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NumLote", estoque.NumLote);
                acessoDadosSqlServer.AdicionarParametros("Qtde", estoque.Qtde);

                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspTesteVendaUEPS").ToString();

                //return idProduto;
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possivel alterar o registro. Detalhe: " + exception.Message);
            }
        }
    }
}
