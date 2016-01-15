using System;

// Adicionando as propriedades da classe
// Namespace`s que contém as classes que manipulam dados
using AcessoBancoDados.Properties;
using System.Data;
using System.Data.SqlClient;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        // Criar a conexão
        // Metodo privado que devolve uma Conexao
        private SqlConnection CriarConexao()
        {
            // retorna uma nova conexao, settings que pega a conexao padrao criada.
            return new SqlConnection(Settings.Default.stringConexao);
        }
        // Paramentros que vão para o Banco
        // Instanciando uma variavel do tipo conjunto de parametros
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        // Metodo para limpar o parametro
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        // Metodo para adicionar parametros 
        // nomeParametro e valorParametro sao os parametros de entrada.
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            // String do tipo coleção de parametros vai add um novo parametro
            // Passando os parametros de entrada.
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        // Persistência - Inserir, Alterar e Excluir
        // CommandType 
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                // Criando uma ponte entre o banco e a aplicação
                SqlConnection sqlConnection = CriarConexao();
                // Abrindo a conexao
                sqlConnection.Open();
                // Criando o comando para levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                // Colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;//Tempo que a conexao pode ficar aberto em segundo

                // Adicionar os parametros na conexao
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executando o comando, ou seja, mandar o comando ir até o banco de dados
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        // Consultar registros do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql )
        {
            try
            {
                // Criando uma ponte entre o banco e a aplicação
                SqlConnection sqlConnection = CriarConexao();
                // Abrindo a conexao
                sqlConnection.Open();
                // Criando o comando para levar a informação para o banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                // Colocando as coisas dentro do comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;//Tempo que a conexao pode ficar aberto em segundo

                // Adicionar os parametros na conexao
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                // Criando um adaptadoor
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                // DataTable = Tabela de dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();
                // Mandar o comando ir até o banco buscar os dados e o adaptador preencher o datable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
