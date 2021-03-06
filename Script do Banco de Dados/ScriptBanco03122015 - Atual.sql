USE [master]
GO
/****** Object:  Database [ControleEstoque]    Script Date: 03/12/2015 10:42:47 ******/
CREATE DATABASE [ControleEstoque]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ControleEstoque', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ControleEstoque.mdf' , SIZE = 90112KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ControleEstoque_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ControleEstoque_log.ldf' , SIZE = 388544KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ControleEstoque] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ControleEstoque].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ControleEstoque] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ControleEstoque] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ControleEstoque] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ControleEstoque] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ControleEstoque] SET ARITHABORT OFF 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ControleEstoque] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ControleEstoque] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ControleEstoque] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ControleEstoque] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ControleEstoque] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ControleEstoque] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ControleEstoque] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ControleEstoque] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ControleEstoque] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ControleEstoque] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ControleEstoque] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ControleEstoque] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ControleEstoque] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ControleEstoque] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ControleEstoque] SET  MULTI_USER 
GO
ALTER DATABASE [ControleEstoque] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ControleEstoque] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ControleEstoque] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ControleEstoque] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarAcesso]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAlterarAcesso]

	@SenhaAtual AS VARCHAR(50),
	@NovaSenha  AS VARCHAR(50)

AS
BEGIN
	IF(NOT EXISTS(SELECT U.Senha FROM tblUsuario AS U WHERE Senha = @SenhaAtual))
		RAISERROR('SENHA ATUAL INVÁLIDA', 14,1)
	ELSE
		BEGIN

			UPDATE	tblUsuario
			SET		Senha = @NovaSenha
			WHERE	Senha = @SenhaAtual

			SELECT 1 AS Retorno
		END
END
GO
/****** Object:  StoredProcedure [dbo].[uspCarregaProdutoAntigo]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCarregaProdutoAntigo]
	@Desc AS VARCHAR(50)
AS
BEGIN

	--INICIO TESTE
		DECLARE
		@Menor_Data AS DATETIME,
		@QtdeDisponivel AS INT

		SELECT @Menor_Data = MIN(DATAENTRADA)  FROM tblEstoque WHERE Descricao = @Desc AND Qtde > 0

		SELECT E.NumLote FROM tblEstoque AS E WHERE DataEntrada = @Menor_Data AND Qtde > 0
	--FIM TESTE

END
GO
/****** Object:  StoredProcedure [dbo].[uspCarregaProdutoNovo]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCarregaProdutoNovo]
	@Desc AS VARCHAR(50)
AS
BEGIN

	--INICIO TESTE
		DECLARE
		@Maior_Data AS DATETIME,
		@QtdeDisponivel AS INT

		SELECT @Maior_Data = MAX(DataEntrada) FROM tblUEPS WHERE Descricao = @Desc AND Qtde > 0

		SELECT E.NumLote FROM tblEstoque AS E WHERE DataEntrada = @Maior_Data AND Qtde > 0
	--FIM TESTE

END
GO
/****** Object:  StoredProcedure [dbo].[uspCategoriaCadastrar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCategoriaCadastrar]
	@Descricao AS VARCHAR(50)
AS
BEGIN
	INSERT INTO tblTipo
	(
		Descricao
	)
	VALUES
	(
		@Descricao
	)

	SELECT @@IDENTITY AS Retorno
END
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspClienteInserir]	
	@NomeFantasia AS VARCHAR(50),
	@Cnpj AS VARCHAR(14)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			IF(EXISTS(SELECT * FROM tblCliente WHERE Cnpj = @Cnpj))
				RAISERROR('Fornecedor já existe !',14,1);

			INSERT INTO tblCliente
			(
				NomeCliente,
				Cnpj
			)
			VALUES
			(
				UPPER (@NomeFantasia),
				@Cnpj
			)

			SELECT @@IDENTITY AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspDescricaoCategoriaQtde]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspDescricaoCategoriaQtde]
AS
BEGIN

		SELECT
			DISTINCT (E.Descricao) AS Descrição_Item,
			T.Descricao AS Categoria_Item,
			MIN(E.DataEntrada) AS Menor_Data_Entrada,
			MAX(E.DataEntrada) AS Maior_Data_Entrada,
			SUM(E.Qtde) AS Qtde_Disponivel,
			AVG(PrecoUnit) as Media_Preco
		FROM
			tblEstoque AS E
		JOIN
			tblTipo AS T
		ON
			E.idTipo = T.id
		WHERE
			Qtde > 0
		GROUP BY 
			E.Descricao,
			T.Descricao

END
GO
/****** Object:  StoredProcedure [dbo].[uspEmailVerificar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEmailVerificar]
	@Email AS VARCHAR(50)
AS
BEGIN
	DECLARE @_email VARCHAR(50)
	DECLARE @Nome VARCHAR(50)
	DECLARE @Senha VARCHAR(50)
	DECLARE @Msg VARCHAR(23)

	IF(EXISTS(SELECT * FROM tblUsuario WHERE Email = @Email))
		BEGIN
			SET @_email = (SELECT EV.Email FROM uvwEmailValidar AS EV WHERE EV.Email = @Email)
			SET @Nome = (SELECT EV.Nome FROM uvwEmailValidar AS EV WHERE EV.Email = @Email)
			SET @Senha = (SELECT EV.Senha FROM uvwEmailValidar AS EV WHERE EV.Email = @Email)
			SELECT @_email AS EMAIL, @Nome NOME, @Senha AS SENHA
		END

	ELSE
		BEGIN
			SET @Msg = 'E-MAIL NÃO ENCONTRADO !'
			SELECT @Msg AS Retorno
		END
END
GO
/****** Object:  StoredProcedure [dbo].[uspEstoqueCarregar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEstoqueCarregar]
AS
BEGIN
	SELECT * FROM uvwEstoqueCarregar
END
GO
/****** Object:  StoredProcedure [dbo].[uspEXCLUIRTODOSOSPRODUTOSDOESTOQUEDETODOSOSESTOQUE]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspEXCLUIRTODOSOSPRODUTOSDOESTOQUEDETODOSOSESTOQUE]
AS
BEGIN
	TRUNCATE TABLE TBLESTOQUE
	TRUNCATE TABLE TBLPEPS
	TRUNCATE TABLE TBLUEPS
	TRUNCATE TABLE TBLCUSTOMEDIO
END
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirUsuario]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspExcluirUsuario]
	@idUsuario AS INT
AS
BEGIN

	IF(NOT EXISTS(SELECT * FROM tblUsuario AS U WHERE idUsuario = @idUsuario))
		RAISERROR('USUÁRIO NÃO EXISTE !',14,1)

	DELETE FROM
			tblUsuario
	WHERE
			idUsuario = @idUsuario

	SELECT @idUsuario AS Retorno
END
GO
/****** Object:  StoredProcedure [dbo].[uspFazerBuscaEstoqueCustoMedio]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFazerBuscaEstoqueCustoMedio]
	@Parametro AS VARCHAR(10),
	@Coluna AS VARCHAR(50)
AS
BEGIN
	
	IF(@Coluna = 'Desc_Mov')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoqueCustoMedioCarregar
		WHERE
			Desc_Mov LIKE '%'+@Parametro+'%' 
	END
	ELSE
	IF(@Coluna = 'NumLote')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoqueCustoMedioCarregar
		WHERE
			NumLote LIKE '%'+@Parametro+'%' 
	END
	IF(@Coluna = 'Descricao')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoqueCustoMedioCarregar
		WHERE
			Descricao LIKE '%'+@Parametro+'%' 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspFazerBuscaEstoquePEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFazerBuscaEstoquePEPS]
	@Parametro AS VARCHAR(10),
	@Coluna AS VARCHAR(50)
AS
BEGIN
	
	IF(@Coluna = 'Desc_Mov')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoquePEPSCarregar
		WHERE
			Desc_Mov LIKE '%'+@Parametro+'%' 
	END
	ELSE
	IF(@Coluna = 'NumLote')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoquePEPSCarregar
		WHERE
			NumLote LIKE '%'+@Parametro+'%' 
	END
	IF(@Coluna = 'Descricao')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoquePEPSCarregar
		WHERE
			Descricao LIKE '%'+@Parametro+'%' 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspFazerBuscaEstoquePrincipal]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFazerBuscaEstoquePrincipal]
	@Parametro AS VARCHAR(10),
	@Coluna AS VARCHAR(50)
AS
BEGIN
	IF(@Coluna = 'Descrição_Item')
	BEGIN	
		SELECT
			*
		FROM
			uvwDescricaoCategoriaQtde
		WHERE
			Descrição_Item LIKE '%'+@Parametro+'%' 
	END
	ELSE
	IF(@Coluna = 'Categoria_Item')
	BEGIN
		SELECT
			*
		FROM
			uvwDescricaoCategoriaQtde
		WHERE
			Categoria_Item LIKE '%'+@Parametro+'%' 
	END
	ELSE
	IF(@Coluna = 'NomeFantasia')
	BEGIN
		SELECT
			*
		FROM
			uvwDescricaoCategoriaQtde
		WHERE
			NomeFantasia LIKE '%'+@Parametro+'%' 
	END

END
GO
/****** Object:  StoredProcedure [dbo].[uspFazerBuscaEstoqueUEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFazerBuscaEstoqueUEPS]
	@Parametro AS VARCHAR(10),
	@Coluna AS VARCHAR(50)
AS
BEGIN
	
	IF(@Coluna = 'Desc_Mov')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoqueUEPSCarregar
		WHERE
			Desc_Mov LIKE '%'+@Parametro+'%' 
	END
	ELSE
	IF(@Coluna = 'NumLote')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoqueUEPSCarregar
		WHERE
			NumLote LIKE '%'+@Parametro+'%' 
	END
	IF(@Coluna = 'Descricao')
	BEGIN	
		SELECT
			Desc_Mov,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		FROM
			uvwEstoqueUEPSCarregar
		WHERE
			Descricao LIKE '%'+@Parametro+'%' 
	END
END
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorInserir]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFornecedorInserir]
	@NomeFantasia AS VARCHAR(50),
	@Cnpj AS VARCHAR(14)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			IF(EXISTS(SELECT * FROM tblFornecedor WHERE Cnpj = @Cnpj))
				RAISERROR('Fornecedor já existe !',14,1);

			INSERT INTO tblFornecedor
			(
				NomeFantasia,
				Cnpj
			)
			VALUES
			(
				UPPER (@NomeFantasia),
				@Cnpj
			)

			SELECT @@IDENTITY AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoComprar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoComprar]
	@idMovimentacao AS INT,
	@Descricao AS VARCHAR(50),
	@idTipo AS INT,
	@Qtde AS INT,
	@PrecoUnit AS DECIMAL(18,2),
	@idFornecedor AS INT
AS
BEGIN
	
	--Gerando um numero aleatorio para o NumLote
	DECLARE 
		@Random INT,
		@Upper INT,
		@Lower INT

	SET @Lower = 1
	SET @Upper = 999

	SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)
	BEGIN TRY
	
		BEGIN TRAN

			--VERIFICA SE O ID DA MOVIMENTAÇÃO ESTA CORRETO SENÃO ESTIVER OCORRE UM ERRO.
			IF(@idMovimentacao = 2 OR @idMovimentacao = 3 OR @idMovimentacao = 4)
				RAISERROR('O idMovimentação informado está incorreto !!!', 14, 1);
			ELSE
				INSERT INTO tblEstoque
				(
					idMovimentacao,
					NumLote,
					Descricao,
					idTipo,
					Qtde,
					PrecoUnit,
					DataEntrada,
					idFornecedor,
					SubTotal
				)
				VALUES
				(
					@idMovimentacao,
					@Random,
					UPPER(@Descricao),
					@idTipo,
					@Qtde,
					@PrecoUnit,
					GETDATE(),
					@idFornecedor,
					@Qtde * @PrecoUnit
				)

				SELECT @Random AS Retorno
		COMMIT TRAN

	END TRY

	BEGIN CATCH
		
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno;
	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoCustoMedio]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoCustoMedio]
	@Descricao AS VARCHAR(100),
	@Qtde AS INT
AS
BEGIN

		DECLARE
		@QtdeTotalDisponivel AS INT,
		@TotalSubTotal AS DECIMAL(18,2),
		@CustoMedio AS DECIMAL(18,2),
		@NumLote AS INT,
		@DataEntrada AS DATETIME,
		@DataSaida AS DATETIME,
		@MenorData AS DATETIME

		SET @QtdeTotalDisponivel = (SELECT SUM(Qtde) FROM tblEstoque WHERE Descricao = @Descricao AND idMovimentacao = 1 AND Qtde > 0)
		SET @TotalSubTotal = (SELECT SUM(Subtotal) FROM tblCustoMedio WHERE Descricao = @Descricao AND idMovimentacao = 1)
		SET @CustoMedio = @TotalSubTotal / @QtdeTotalDisponivel
		SET @MenorData = (SELECT MIN(DataEntrada) FROM tblCustoMedio WHERE Descricao = @Descricao AND idMovimentacao = 1 AND Qtde > 0)
		SET @NumLote = (SELECT CM.NumLote FROM tblCustoMedio AS CM WHERE Descricao = @Descricao AND idMovimentacao = 1 AND Qtde > 0 AND DataEntrada = @MenorData)
		SET @DataEntrada = (SELECT cm.DataEntrada FROM tblCustoMedio AS CM WHERE Descricao = @Descricao AND idMovimentacao = 1 AND Qtde > 0 AND NumLote = @NumLote)
		SET @DataSaida = (SELECT CM.DataSaida FROM tblCustoMedio AS CM WHERE Descricao = @Descricao AND idMovimentacao = 1 AND Qtde > 0 AND NumLote = @NumLote)


		INSERT INTO tblCustoMedio
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			2,
			@NumLote,
			@Descricao,
			@Qtde,
			@CustoMedio,
			@DataEntrada,
			GETDATE(),
			@CustoMedio * @Qtde,
			10,
			(@Qtde * @CustoMedio) * 1.1
		)
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoVenderPEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoVenderPEPS]
	@NumLote AS INT,
	@Qtde AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			DECLARE
				@QtdeEstoque AS INT,
				@Desc AS VARCHAR(50),
				@IdMov AS INT,
				@PrecoUnit AS DECIMAL(18,2),
				@DataEntrada AS DATETIME, 
				@Result AS DECIMAL(18,2),
				@MenorData AS DATETIME,
				@QtdeUEPS AS INT,
				@QTDEpPEPS AS INT

				SET @QtdeUEPS = @Qtde

				SET @Desc = (SELECT E.Descricao FROM tblPEPS AS E WHERE NumLote = @NumLote AND idMovimentacao =1)
				SET @QtdeEstoque = (SELECT SUM(E.Qtde) FROM tblEstoque AS E WHERE /*NumLote = @NumLote AND*/ idMovimentacao = 1 AND Qtde > 0)				 
				SET @IdMov = (SELECT E.idMovimentacao FROM tblPEPS AS E WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit = (SELECT E.PrecoUnit FROM tblEstoque AS E WHERE NumLote = @NumLote)
				SET @DataEntrada = (SELECT E.DataEntrada FROM tblEstoque AS E WHERE NumLote = @NumLote)
				
				
				
				WHILE @Qtde > 0
				BEGIN
					IF(@QtdeEstoque < @Qtde AND @QtdeEstoque > 0)
					BEGIN
						UPDATE	tblEstoque
						SET		Qtde = Qtde - @QtdeEstoque
						WHERE	NumLote = @NumLote
					
						INSERT INTO tblPEPS
						(
							idMovimentacao,
							NumLote,
							Descricao,
							Qtde,
							PrecoUnit,
							DataEntrada,
							DataSaida,
							Subtotal,
							ICMS,
							Total
						)
						VALUES
						(
							2,
							@NumLote,
							@Desc,
							@QtdeEstoque,
							@PrecoUnit,
							@DataEntrada,
							GETDATE(),
							@QtdeEstoque * @PrecoUnit,
							10,
							(@QtdeEstoque * @PrecoUnit) * 1.1
						)

						SET @Qtde = @Qtde - @QtdeEstoque
						SET @MenorData = (SELECT MIN(E.DataEntrada) FROM tblEstoque E WHERE Qtde > 0)
						SET @NumLote = (SELECT E.NumLote FROM tblEstoque AS E WHERE DataEntrada = @MenorData)
						
					END 
					ELSE

						IF(@QtdeEstoque >= @Qtde AND @QtdeEstoque > 0 AND @IdMov = 1)
						BEGIN	
							
							SET @QTDEpPEPS = (SELECT P.Qtde FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)			
							
							UPDATE	tblEstoque
							SET		Qtde = Qtde - @QTDEpPEPS
							WHERE	NumLote = @NumLote


						INSERT INTO tblPEPS
						(
							idMovimentacao,
							NumLote,
							Descricao,
							Qtde,
							PrecoUnit,
							DataEntrada,
							DataSaida,
							Subtotal,
							ICMS,
							Total
						)
						VALUES
						(
							2,
							@NumLote,
							@Desc,
							@QTDEpPEPS,
							@PrecoUnit,
							@DataEntrada,
							GETDATE(),
							@Qtde * @PrecoUnit,
							10,
							(@Qtde * @PrecoUnit) * 1.1 
						)

						SET @MenorData = (SELECT MIN(E.DataEntrada) FROM tblEstoque E WHERE Qtde > 0)
						SET @NumLote = (SELECT E.NumLote FROM tblEstoque AS E WHERE DataEntrada = @MenorData)

						SET @Qtde = @Qtde - @QTDEpPEPS
						SET @QtdeEstoque = @QtdeEstoque - @QTDEpPEPS
												
						END 
					END

					EXEC uspProdutoVenderUEPS @Desc, @QtdeUEPS

					SELECT 0 AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoVenderUEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoVenderUEPS]
	@Desc AS VARCHAR(50),
	@Qtde AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			DECLARE
				@QtdeEstoque AS INT,
				@IdMov AS INT,
				@PrecoUnit AS DECIMAL(18,2),
				@DataEntrada AS DATETIME,
				@NumLote AS INT,
				@MaiorData AS DATETIME,
				@CustoMedio AS INT

				SET @CustoMedio = @Qtde

				SET @MaiorData = (SELECT MAX(E.DataEntrada) FROM tblEstoque AS E WHERE Descricao = @Desc)
				SET @NumLote = (SELECT E.NumLote FROM tblEstoque AS E WHERE DataEntrada = @MaiorData)
				SET @Desc = (SELECT E.Descricao FROM tblUEPS AS E WHERE NumLote = @NumLote AND idMovimentacao =1)
				SET @QtdeEstoque = (SELECT E.Qtde FROM tblUEPS AS E WHERE NumLote = @NumLote AND idMovimentacao = 1)				 
				SET @IdMov = (SELECT E.idMovimentacao FROM tblUEPS AS E WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit = (SELECT E.PrecoUnit FROM tblEstoque AS E WHERE NumLote = @NumLote)
				SET @DataEntrada = (SELECT E.DataEntrada FROM tblEstoque AS E WHERE NumLote = @NumLote)

				IF(@QtdeEstoque = 0)
				BEGIN
					RAISERROR('Produto zerado !',14,1);
				END

				WHILE @Qtde > 0
				BEGIN
					IF(@QtdeEstoque < @Qtde AND @QtdeEstoque > 0)
					BEGIN

						INSERT INTO tblUEPS
						(
							idMovimentacao,
							NumLote,
							Descricao,
							Qtde,
							PrecoUnit,
							DataEntrada,
							DataSaida,
							Subtotal,
							ICMS,
							Total
						)
						VALUES
						(
							2,
							@NumLote,
							@Desc,
							@QtdeEstoque,
							@PrecoUnit,
							@DataEntrada,
							GETDATE(),
							@QtdeEstoque * @PrecoUnit,
							10,
							(@Qtde * @PrecoUnit) * 1.1 
						)

						SET @Qtde = @Qtde - @QtdeEstoque
						SET @MaiorData = (SELECT MAX(E.DataEntrada) FROM tblEstoque AS E WHERE Descricao = @Desc AND DataEntrada < @MaiorData)
						SET @NumLote = (SELECT E.NumLote FROM tblEstoque AS E WHERE DataEntrada = @MaiorData)
						--SELECT @Qtde - @QtdeEstoque AS Retorno
					END
					ELSE

					IF(@QtdeEstoque >= @Qtde AND @QtdeEstoque > 0 AND @IdMov = 1)
					BEGIN
					
						INSERT INTO tblUEPS
						(
							idMovimentacao,
							NumLote,
							Descricao,
							Qtde,
							PrecoUnit,
							DataEntrada,
							DataSaida,
							Subtotal,
							ICMS,
							Total
						)
						VALUES
						(
							2,
							@NumLote,
							@Desc,
							@Qtde,
							@PrecoUnit,
							@DataEntrada,
							GETDATE(),
							@Qtde * @PrecoUnit,
							10,
							(@Qtde * @PrecoUnit) * 1.1 
						)

						SET @Qtde = 0
						--SELECT 0 AS Retorno
					END
				END

				EXEC uspProdutoCustoMedio @Desc, @CustoMedio

				SELECT 0 AS Retorno
				
		COMMIT TRAN
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspTesteVendaCM]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery12.sql|7|0|C:\Users\Marcelo\AppData\Local\Temp\~vsF310.sql
CREATE PROCEDURE [dbo].[uspTesteVendaCM]
	@NumLote AS INT,
	@Qtde AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

		DECLARE
		--qtde e valor total do estoque
		@QtdeTotalEstoque AS INT,
		@TotalSubtotal AS DECIMAL(18,2),
		
		--qtde e valor total vendido
		@QtdeTotalVendido AS INT,
		@TotalSubtotalVendido AS DECIMAL(18,2),
		
		--recebe os valores atuais
		@TotalQtde AS INT,
		@TotalValor AS DECIMAL(18,2),

		--recebe o custo medio 
		@CustoMedioProduto AS DECIMAL(18,2),

		@Descricao AS VARCHAR(50),
		@DataEntrada AS DATETIME,
		@PrecoUnit AS DECIMAL(18,2)

		SET @DataEntrada = (SELECT CM.DataEntrada FROM tblCustoMedio AS CM WHERE NumLote = @NumLote AND idMovimentacao = 1 AND Qtde > 0)
		SET @Descricao = (SELECT CM.Descricao FROM tblCustoMedio AS CM WHERE NumLote = @NumLote AND idMovimentacao = 1)

		--soma a qtde total do estoque e
		--soma o valor total do subtotal do estoque
		SET @QtdeTotalEstoque = (SELECT SUM(CM.Qtde) FROM tblCustoMedio AS CM WHERE idMovimentacao = 1 AND Descricao = @Descricao) 
		SET @TotalSubtotal = (SELECT SUM(CM.Subtotal) FROM tblCustoMedio AS CM WHERE idMovimentacao = 1 AND Descricao = @Descricao)

		--soma a qtde total vendida e
		--soma o valor total do subtotal de venda
		SET @QtdeTotalVendido = (SELECT SUM(CM.Qtde) FROM tblCustoMedio AS CM WHERE idMovimentacao = 2) -- AND NumLote = @NumLote)
		SET @TotalSubtotalVendido = (SELECT SUM(CM.Subtotal) FROM tblCustoMedio AS CM WHERE idMovimentacao = 2)-- AND NumLote = @NumLote)

		--se foi vendido atribui o valor achado
		IF(@QtdeTotalVendido != 0)
		BEGIN
			SET @QtdeTotalVendido = @QtdeTotalVendido
			SET @TotalSubtotalVendido = @TotalSubtotalVendido
		END
		ELSE -- senão atribui zero
		BEGIN
			SET @QtdeTotalVendido = 0
			SET @TotalSubtotalVendido = 0
		END

		--total do estoque - total vendido
		SET @TotalQtde = @QtdeTotalEstoque - @QtdeTotalVendido

		--total do valor do estoque - total do valor vendido
		SET @TotalValor = @TotalSubtotal - @TotalSubtotalVendido

		--atribui o valor medio do produto
		SET @CustoMedioProduto = @TotalValor / @TotalQtde
		
		--se a qtde que eu quero for igual a do estoque
		if(@Qtde = @TotalQtde)
		BEGIN
			INSERT INTO tblCustoMedio
			(
				idMovimentacao,
				NumLote,
				Descricao,
				Qtde,
				PrecoUnit,
				DataEntrada,
				DataSaida,
				Subtotal,
				ICMS,
				Total
			)
			VALUES
			(
				2,
				@NumLote,
				@Descricao,
				@Qtde,
				@CustoMedioProduto,
				@DataEntrada,
				GETDATE(),
				@CustoMedioProduto * @Qtde,
				10,
				(@CustoMedioProduto * @Qtde) * 1.1
			)
		END

		--se a qtde que eu quero for menor que a do estoque
		if(@Qtde < @TotalQtde)
		BEGIN
				SET @TotalQtde = (SELECT CM.Qtde FROM tblCustoMedio AS CM WHERE NumLote = @NumLote AND Qtde > 0 AND idMovimentacao = 1)
				SET @Qtde = @Qtde - @TotalQtde
				
				
				INSERT INTO tblCustoMedio
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Descricao,
					@TotalQtde,
					@CustoMedioProduto,
					@DataEntrada,
					GETDATE(),
					@CustoMedioProduto * @Qtde,
					10,
					(@CustoMedioProduto * @Qtde) * 1.1
				)

			END
		--se a qtde que eu quero for maior que a do estoque
		IF(@QtdeTotalVendido = 0)-- se a qtde for igual pq nao vendeu nada ainda
		BEGIN
		IF(@Qtde > @TotalQtde)-- se a qtde que eu quero for maior que tem no estoque
		BEGIN
			WHILE(@Qtde > 0)
			BEGIN
				-- a qtde que eu quero - a qtde que tem
				IF(@Qtde > @TotalQtde)
					SET @Qtde = @Qtde - @TotalQtde
				ELSE
				IF(@Qtde < @TotalQtde)
				BEGIN
					SET @TotalQtde = @Qtde
					SET @Qtde =0
				END
				INSERT INTO tblCustoMedio
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Descricao,
					@Qtde,
					@CustoMedioProduto,
					@DataEntrada,
					GETDATE(),
					@CustoMedioProduto * @Qtde,
					10,
					(@CustoMedioProduto * @Qtde) * 1.1
				)

				-- pegar um novo lote
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblCustoMedio AS P WHERE NumLote != @NumLote AND idMovimentacao = 1 AND DataEntrada < @DataEntrada)
				SET @NumLote =		(SELECT P.NumLote			FROM tblCustoMedio AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @Descricao =			(SELECT P.Descricao			FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @TotalQtde =	(SELECT P.Qtde				FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit =	(SELECT P.PrecoUnit			FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @QtdeTotalVendido =	(SELECT SUM(P.Qtde)			FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 2)

				IF(@QtdeTotalVendido != 0 )
					SET @QtdeTotalVendido = @QtdeTotalVendido
				ELSE
				BEGIN
					SET @QtdeTotalVendido = 0
				END

				SET @TotalQtde = @TotalQtde - @QtdeTotalVendido
			END
		END
	END
	ELSE-- ja vendeu
	BEGIN
		IF(@Qtde > @TotalQtde)-- se a qtde que eu quero for maior que tem no estoque
		BEGIN	
			WHILE(@Qtde > 0)
			BEGIN
			
				INSERT INTO tblCustoMedio
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Descricao,
					@Qtde,
					@CustoMedioProduto,
					@DataEntrada,
					GETDATE(),
					@CustoMedioProduto * @Qtde,
					10,
					(@CustoMedioProduto * @Qtde) * 1.1
				)
				
				--SET @QtdepUEPS	= @QtdepUEPS - @QtdepTirar-- a qtde do estoque - a qtde que ja vendeu
				SET @Qtde = @Qtde - @QtdeTotalVendido-- a qtde que eu quero - a qtde real do estoque
				
				-- pegar um novo lote
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblCustoMedio AS P WHERE NumLote != @NumLote AND idMovimentacao = 1 AND DataEntrada < @DataEntrada)
				SET @NumLote =		(SELECT P.NumLote			FROM tblCustoMedio AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @Descricao =			(SELECT P.Descricao			FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @TotalQtde =	(SELECT P.Qtde				FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit =	(SELECT P.PrecoUnit			FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @QtdeTotalVendido =	(SELECT SUM(P.Qtde)		FROM tblCustoMedio AS P WHERE NumLote = @NumLote AND idMovimentacao = 2)

				-- atribuir zero senão foi vendido nada
				IF(@QtdeTotalVendido != 0 )
					SET @QtdeTotalVendido = @QtdeTotalVendido
				ELSE
				BEGIN
					SET @QtdeTotalVendido = 0
					SET @TotalQtde = @Qtde
				END
				SET @TotalQtde = @TotalQtde- @QtdeTotalVendido
			END
		END
	END
		SELECT @@IDENTITY AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspTesteVendaPEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTesteVendaPEPS]
	@NumLote AS INT,
	@Qtde AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			DECLARE
				@Desc AS VARCHAR(50),
				@QtdepPEPS AS INT,
				@PrecoUnit AS DECIMAL(18,2),
				@DataEntrada AS DATETIME,
				@QtdepTirar AS INT,
				@QtdeParaUEPS AS INT

				SET @QtdepTirar = 0
				SET @QtdeParaUEPS = @Qtde

			-- pegar informações do lote
			SET @Desc = (SELECT P.Descricao FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
			SET @QtdepPEPS = (SELECT P.Qtde FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
			SET @PrecoUnit = (SELECT P.PrecoUnit FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
			SET @DataEntrada = (SELECT P.DataEntrada FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
			SET @QtdepTirar = (SELECT SUM(P.Qtde) FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 2)

			-- tirar a qtd do estoque - qtde já tirada
			if(@QtdepTirar != '')
				SET @QtdepPEPS = @QtdepPEPS - @QtdepTirar

			WHILE(@Qtde > 0)
	
			BEGIN
				INSERT INTO tblPEPS
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Desc,
					@QtdepPEPS,
					@PrecoUnit,
					@DataEntrada,
					GETDATE(),
					@PrecoUnit * @QtdepPEPS,
					10,
					(@QtdepPEPS * @PrecoUnit) * 1.1 
				)

				UPDATE tblEstoque
				SET Qtde = Qtde - @QtdepPEPS
				WHERE NumLote = @NumLote

				--mudar a quantidade
				SET @Qtde = @Qtde - @QtdepPEPS
		
				IF(@Qtde > 0)
				BEGIN

				--pegar outro lote
		
				SET @DataEntrada = (SELECT MIN(P.DataEntrada) FROM tblPEPS AS P WHERE NumLote != @NumLote AND idMovimentacao = 1 AND DataEntrada > @DataEntrada)
				SET @NumLote = (SELECT P.NumLote FROM tblPEPS AS P WHERE NumLote != @NumLote AND DataEntrada = @DataEntrada)
				SET @DataEntrada = (SELECT MIN(P.DataEntrada) FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @Desc = (SELECT P.Descricao FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @QtdepPEPS = (SELECT P.Qtde FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit = (SELECT P.PrecoUnit FROM tblPEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		
				INSERT INTO tblPEPS
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Desc,
					@Qtde,
					@PrecoUnit,
					@DataEntrada,
					GETDATE(),
					@PrecoUnit * @Qtde,
					10,
					(@Qtde * @PrecoUnit) * 1.1 
				)

				UPDATE tblEstoque
				SET Qtde = Qtde - @Qtde
				WHERE NumLote = @NumLote

				--mudar a quantidade
				SET @Qtde = @Qtde - @QtdepPEPS

				END
	END

		SET @DataEntrada =	(SELECT MAX(U.DataEntrada)	FROM tblUEPS AS U WHERE idMovimentacao = 1 AND Qtde > 0)
		SET @NumLote =		(SELECT P.NumLote			FROM tblUEPS AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)

		EXEC uspTesteVendaUEPS @NumLote, @QtdeparaUEPS

	SELECT @@IDENTITY AS Retorno
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspTesteVendaUEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspTesteVendaUEPS]
	@NumLote AS INT,
	@Qtde AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

	DECLARE
		@Desc AS VARCHAR(50),
		@QtdepUEPS AS INT,
		@PrecoUnit AS DECIMAL(18,2),
		@DataEntrada AS DATETIME,
		@QtdepTirar AS INT,
		@QtdeparaCM AS INT

		SET @QtdeparaCM = @Qtde

	-- pegar informações do lote
	SET @Desc =			(SELECT P.Descricao		FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
	SET @QtdepUEPS =	(SELECT P.Qtde			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
	SET @PrecoUnit =	(SELECT P.PrecoUnit		FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
	SET @DataEntrada =	(SELECT P.DataEntrada	FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
	SET @QtdepTirar =	(SELECT SUM(P.Qtde)		FROM tblUEPS AS P WHERE idMovimentacao = 2 AND Numlote = @NumLote)
	
	-- atribuir zero senão foi vendido nada
	IF(@QtdepTirar != 0 )
	BEGIN
		SET @QtdepTirar = @QtdepTirar
		SET @QtdepUEPS = @QtdepUEPS - @QtdepTirar
	END
	ELSE
		SET @QtdepTirar = 0
	
	IF(@QtdepTirar = 0)-- se a qtde for igual pq nao vendeu nada ainda
	BEGIN
		IF(@Qtde = @QtdepUEPS)-- se a qtde for igual
		BEGIN
			INSERT INTO tblUEPS
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Desc,
					@Qtde,
					@PrecoUnit,
					@DataEntrada,
					GETDATE(),
					@PrecoUnit * @Qtde,
					10,
					(@Qtde * @PrecoUnit) * 1.1 
				)
				SET @Qtde = 0
		END
	END
	ELSE -- se já vendeu
	BEGIN
		IF(@Qtde = @QtdepUEPS)
		BEGIN
			--  a qtde que tem - a qtde que ja vendeu
			SET @QtdepUEPS = @QtdepUEPS - @QtdepTirar
			INSERT INTO tblUEPS
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Desc,
					@QtdepUEPS,
					@PrecoUnit,
					@DataEntrada,
					GETDATE(),
					@PrecoUnit * @QtdepUEPS,
					10,
					(@QtdepUEPS * @PrecoUnit) * 1.1 
				)
				SET @Qtde = 0
		END
	END

	IF(@QtdepTirar = 0)-- se a qtde for igual pq nao vendeu nada ainda
	BEGIN
		IF(@Qtde > @QtdepUEPS)-- se a qtde que eu quero for maior que tem no estoque
		BEGIN
			WHILE(@Qtde > 0)
			BEGIN
			-- a qtde que eu quero - a qtde que tem
			IF(@Qtde > @QtdepUEPS)
				SET @Qtde = @Qtde - @QtdepUEPS
			ELSE
			IF(@Qtde < @QtdepUEPS)
			BEGIN
				SET @QtdepUEPS = @Qtde
				SET @Qtde =0
			END
			INSERT INTO tblUEPS
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Desc,
					@QtdepUEPS,-- qtde que eu quero
					@PrecoUnit,
					@DataEntrada,
					GETDATE(),
					@PrecoUnit * @QtdepUEPS,
					10,
					(@QtdepUEPS * @PrecoUnit) * 1.1 
				)

				-- pegar um novo lote
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote != @NumLote AND idMovimentacao = 1 AND DataEntrada < @DataEntrada)
				SET @NumLote =		(SELECT P.NumLote			FROM tblUEPS AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @Desc =			(SELECT P.Descricao			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @QtdepUEPS =	(SELECT P.Qtde				FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit =	(SELECT P.PrecoUnit			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @QtdepTirar =	(SELECT SUM(P.Qtde)			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 2)

				IF(@QtdepTirar != 0 )
					SET @QtdepTirar = @QtdepTirar
				ELSE
				BEGIN
					SET @QtdepTirar = 0
				END

				SET @QtdepUEPS = @QtdepUEPS - @QtdepTirar
			END
		END
	END
	ELSE-- ja vendeu
	BEGIN
		IF(@Qtde > @QtdepUEPS)-- se a qtde que eu quero for maior que tem no estoque
		BEGIN	
			WHILE(@Qtde > 0)
			BEGIN
			
				INSERT INTO tblUEPS
				(
					idMovimentacao,
					NumLote,
					Descricao,
					Qtde,
					PrecoUnit,
					DataEntrada,
					DataSaida,
					Subtotal,
					ICMS,
					Total
				)
				VALUES
				(
					2,
					@NumLote,
					@Desc,
					@QtdepUEPS, -- a qtde que eu quero
					@PrecoUnit,
					@DataEntrada,
					GETDATE(),
					@PrecoUnit * @QtdepUEPS,
					10,
					(@QtdepUEPS * @PrecoUnit) * 1.1 
				)
				
				--SET @QtdepUEPS	= @QtdepUEPS - @QtdepTirar-- a qtde do estoque - a qtde que ja vendeu
				SET @Qtde = @Qtde - @QtdepUEPS -- a qtde que eu quero - a qtde real do estoque
				
				-- pegar um novo lote
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote != @NumLote AND idMovimentacao = 1 AND DataEntrada < @DataEntrada)
				SET @NumLote =		(SELECT P.NumLote			FROM tblUEPS AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)
				SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @Desc =			(SELECT P.Descricao			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @QtdepUEPS =	(SELECT P.Qtde				FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit =	(SELECT P.PrecoUnit			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @QtdepTirar =	(SELECT SUM(P.Qtde)		FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 2)

				-- atribuir zero senão foi vendido nada
				IF(@QtdepTirar != 0 )
					SET @QtdepTirar = @QtdepTirar
				ELSE
				BEGIN
					SET @QtdepTirar = 0
					SET @QtdepUEPS = @Qtde
				END
				SET @QtdepUEPS = @QtdepUEPS - @QtdepTirar
			END
		END
	END

	IF(@QtdepTirar = 0)-- se a qtde for igual pq nao vendeu nada ainda
	BEGIN
		IF(@Qtde < @QtdepUEPS)--se a qtde que eu quero for menor do que tem no estoque
		BEGIN
			INSERT INTO tblUEPS
			(
				idMovimentacao,
				NumLote,
				Descricao,
				Qtde,
				PrecoUnit,
				DataEntrada,
				DataSaida,
				Subtotal,
				ICMS,
				Total
			)
			VALUES
			(
				2,
				@NumLote,
				@Desc,
				@Qtde,
				@PrecoUnit,
				@DataEntrada,
				GETDATE(),
				@PrecoUnit * @Qtde,
				10,
				(@Qtde * @PrecoUnit) * 1.1 
			)
		END
	END
	ELSE-- já vendeu
	BEGIN
		INSERT INTO tblUEPS
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			2,
			@NumLote,
			@Desc,
			@Qtde,
			@PrecoUnit,
			@DataEntrada,
			GETDATE(),
			@PrecoUnit * @Qtde,
			10,
			(@Qtde * @PrecoUnit) * 1.1 
		)
	END
	
		SET @DataEntrada =	(SELECT MAX(U.DataEntrada)	FROM tblUEPS AS U WHERE idMovimentacao = 1 AND Qtde > 0)
		SET @NumLote =		(SELECT P.NumLote			FROM tblUEPS AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)
		
		EXEC uspTesteVendaCM @NumLote, @QtdeparaCM

	SELECT @@IDENTITY AS Retorno
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END





	/*
	-- tirar a qtd do estoque - qtde já tirada
	if(@QtdepTirar != '')
	BEGIN	

		SET @QtdepUEPS = @QtdepUEPS - @QtdepTirar
		INSERT INTO tblUEPS
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			2,
			@NumLote,
			@Desc,
			@QtdepUEPS,
			@PrecoUnit,
			@DataEntrada,
			GETDATE(),
			@PrecoUnit * @Qtde,
			10,
			(@Qtde * @PrecoUnit) * 1.1 
		)			
	
		SET @Qtde = @Qtde - @QtdepUEPS
				
	END

	-- primeira venda
	WHILE(@Qtde > 0)
	BEGIN
		
		SET @QtdepTirar = 0
		SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote != @NumLote AND idMovimentacao = 1 AND DataEntrada < @DataEntrada)
		SET @NumLote =		(SELECT P.NumLote			FROM tblUEPS AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)
		SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @Desc =			(SELECT P.Descricao			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @QtdepUEPS =	(SELECT P.Qtde				FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @PrecoUnit =	(SELECT P.PrecoUnit			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @QtdepTirar =	(SELECT SUM(P.Qtde)		FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 2)

		INSERT INTO tblUEPS
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			2,
			@NumLote,
			@Desc,
			@QtdepUEPS,
			@PrecoUnit,
			@DataEntrada,
			GETDATE(),
			@PrecoUnit * @QtdepUEPS,
			10,
			(@QtdepUEPS * @PrecoUnit) * 1.1 
		)

		--mudar a quantidade
		SET @Qtde = @Qtde - @QtdepUEPS
		

		IF(@Qtde > 0)
		BEGIN

		--pegar outro lote
		 
		SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote != @NumLote AND idMovimentacao = 1 AND DataEntrada < @DataEntrada)
		SET @NumLote =		(SELECT P.NumLote			FROM tblUEPS AS P WHERE DataEntrada = @DataEntrada AND idMovimentacao = 1)
		SET @DataEntrada =	(SELECT MAX(P.DataEntrada)	FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @Desc =			(SELECT P.Descricao			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @QtdepUEPS =	(SELECT P.Qtde				FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @PrecoUnit =	(SELECT P.PrecoUnit			FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 1)
		SET @QtdepTirar =	(SELECT SUM(P.Qtde)		FROM tblUEPS AS P WHERE NumLote = @NumLote AND idMovimentacao = 2)

		INSERT INTO tblUEPS
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			2,
			@NumLote,
			@Desc,
			@Qtde,
			@PrecoUnit,
			@DataEntrada,
			GETDATE(),
			@PrecoUnit * @Qtde,
			10,
			(@Qtde * @PrecoUnit) * 1.1 
		)

		--mudar a quantidade
		SET @Qtde = @Qtde - @QtdepUEPS

		END

	END
	
	SELECT @@IDENTITY AS Retorno

	COMMIT TRAN
	END TRY
	BEGIN CATCH
		
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END*/
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioCadastrar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioCadastrar]
	@Nome AS VARCHAR(50),
	@SobreNome AS VARCHAR(50),
	@DataNascimento AS DATE,
	@Email AS VARCHAR(50),
	@Senha AS VARCHAR(50),
	@idNivel AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			IF(EXISTS(SELECT * FROM tblUsuario WHERE Senha = @Senha ))
			BEGIN
				RAISERROR('Usuário e Senha já existe', 14,1);
			END
			ELSE
			BEGIN
				INSERT INTO tblUsuario
				(
					Nome,
					SobreNome,
					DataNascimento,
					Email,
					Senha,
					idNivel
				)
				VALUES
				(
					UPPER(@Nome),
					UPPER(@SobreNome),
					@DataNascimento,
					@Email,
					@Senha,
					@idNivel
				)
				
				COMMIT TRAN
				SELECT @@IDENTITY AS Retorno;
			END
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioValidar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioValidar]
	@Nome VARCHAR(50),
	@Senha VARCHAR(50)
AS
BEGIN
	DECLARE @idNivel INT
	DECLARE @msg VARCHAR(24)

	IF(NOT EXISTS(SELECT * FROM uvwUsuarioNivelAcesso AS AC WHERE AC.NOME = @Nome AND AC.SENHA = @Senha))
		BEGIN
			SET @msg = 'NOME OU SENHA INVALIDO'
			SELECT @msg AS Mensagem
		END
	ELSE
		BEGIN 
			SET @idNivel = (SELECT AC.idAcesso FROM uvwUsuarioNivelAcesso AS AC WHERE AC.NOME = @Nome AND AC.SENHA = @Senha)
			SELECT @idNivel AS NivelAcesso
	END
END
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](50) NOT NULL,
	[Cnpj] [varchar](14) NOT NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCustoMedio]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustoMedio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMovimentacao] [int] NOT NULL,
	[NumLote] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Qtde] [int] NOT NULL,
	[PrecoUnit] [decimal](18, 2) NOT NULL,
	[DataEntrada] [datetime] NULL,
	[DataSaida] [datetime] NULL,
	[Subtotal] [decimal](18, 2) NOT NULL,
	[ICMS] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblCusotMedio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEstoque]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEstoque](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMovimentacao] [int] NOT NULL,
	[NumLote] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[idTipo] [int] NOT NULL,
	[Qtde] [int] NOT NULL,
	[PrecoUnit] [decimal](18, 2) NOT NULL,
	[DataEntrada] [datetime] NOT NULL,
	[idFornecedor] [int] NULL,
	[SubTotal] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tblEstoque] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFornecedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NomeFantasia] [varchar](50) NOT NULL,
	[Cnpj] [varchar](14) NOT NULL,
 CONSTRAINT [PK_tblFornecedor_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMovimentação]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMovimentação](
	[idMovimentacao] [int] NOT NULL,
	[Desc_Mov] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblMovimentação] PRIMARY KEY CLUSTERED 
(
	[idMovimentacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNivelAcesso]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNivelAcesso](
	[idNivel] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblNivelAcesso] PRIMARY KEY CLUSTERED 
(
	[idNivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPEPS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMovimentacao] [int] NOT NULL,
	[NumLote] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Qtde] [int] NOT NULL,
	[PrecoUnit] [decimal](18, 2) NOT NULL,
	[DataEntrada] [datetime] NULL,
	[DataSaida] [datetime] NULL,
	[Subtotal] [decimal](18, 2) NOT NULL,
	[ICMS] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblPEPS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTipo]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTipo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblTipo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUEPS]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUEPS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idMovimentacao] [int] NOT NULL,
	[Numlote] [int] NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Qtde] [int] NOT NULL,
	[PrecoUnit] [decimal](18, 2) NOT NULL,
	[DataEntrada] [datetime] NULL,
	[DataSaida] [datetime] NULL,
	[Subtotal] [decimal](18, 2) NOT NULL,
	[ICMS] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblUEPS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[SobreNome] [varchar](50) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[idNivel] [int] NOT NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[uvwConsultarDescricaoCategoria]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[uvwConsultarDescricaoCategoria]

AS
	SELECT 
		E.Descricao AS Bebida,
		T.Descricao AS Categoria,
		E.PrecoUnit AS Preco,
		E.Qtde AS Quantidade
	FROM
		tblEstoque AS E
	JOIN
		tblTipo AS T
	ON
		E.idTipo = T.id


GO
/****** Object:  View [dbo].[uvwDescricaoCategoriaQtde]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[uvwDescricaoCategoriaQtde]
AS
		SELECT
			DISTINCT (E.Descricao) AS Descrição_Item,
			T.Descricao AS Categoria_Item,
			MIN(E.DataEntrada) AS Menor_Data_Entrada,
			MAX(E.DataEntrada) AS Maior_Data_Entrada,
			SUM(E.Qtde) AS Qtde_Disponivel,
			AVG(PrecoUnit) as Media_Preco,
			F.NomeFantasia
		FROM
			tblEstoque AS E
		JOIN
			tblTipo AS T
		ON
			E.idTipo = T.id
		JOIN
			tblFornecedor AS F
		ON
			E.idFornecedor = F.id
		WHERE
			Qtde > 0
		GROUP BY 
			E.Descricao,
			T.Descricao,
			F.NomeFantasia

GO
/****** Object:  View [dbo].[uvwEmailValidar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uvwEmailValidar]
AS

	SELECT
		U.Nome,
		U.Senha,
		U.Email
	FROM
		tblUsuario AS U
GO
/****** Object:  View [dbo].[uvwEstoqueCarregar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uvwEstoqueCarregar]

AS
	SELECT 
		M.Desc_Mov,
		E.NumLote,
		E.Descricao AS DescriçãoItem,
		T.Descricao AS CategoriaItem,
		E.Qtde,
		E.PrecoUnit,
		E.DataEntrada,
		F.NomeFantasia
	FROM
		tblEstoque AS E
	JOIN
		tblMovimentação AS M
	ON
		E.idMovimentacao = M.idMovimentacao
	JOIN
		tblTipo AS T
	ON
		E.idTipo = T.id
	JOIN
		tblFornecedor AS F
	ON
		E.idFornecedor = F.id
GO
/****** Object:  View [dbo].[uvwEstoqueCustoMedioCarregar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[uvwEstoqueCustoMedioCarregar]
AS
	SELECT
		M.Desc_Mov,
		P.NumLote,
		P.Descricao,
		P.Qtde,
		P.PrecoUnit,
		P.DataEntrada,
		P.DataSaida,
		P.Subtotal,
		P.ICMS,
		P.Total
	FROM
		tblCustoMedio AS P
	JOIN
		tblMovimentação AS M
	ON
		P.idMovimentacao = M.idMovimentacao
	GROUP BY
		P.DataEntrada,
		M.Desc_Mov,
		P.NumLote,
		P.Descricao,
		P.Qtde,
		P.PrecoUnit,
		P.DataSaida,
		P.Subtotal,
		P.ICMS,
		P.Total

GO
/****** Object:  View [dbo].[uvwEstoquePEPSCarregar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[uvwEstoquePEPSCarregar]
AS
	SELECT
		M.Desc_Mov,
		P.NumLote,
		P.Descricao,
		P.Qtde,
		P.PrecoUnit,
		P.DataEntrada,
		P.DataSaida,
		P.Subtotal,
		P.ICMS,
		P.Total
	FROM
		tblPEPS AS P
	JOIN
		tblMovimentação AS M
	ON
		P.idMovimentacao = M.idMovimentacao
	GROUP BY
		P.DataEntrada,
		M.Desc_Mov,
		P.NumLote,
		P.Descricao,
		P.Qtde,
		P.PrecoUnit,
		P.DataSaida,
		P.Subtotal,
		P.ICMS,
		P.Total



GO
/****** Object:  View [dbo].[uvwEstoqueUEPSCarregar]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[uvwEstoqueUEPSCarregar]
AS
	SELECT
		M.Desc_Mov,
		U.NumLote,
		U.Descricao,
		U.Qtde,
		U.PrecoUnit,
		U.DataEntrada,
		U.DataSaida,
		U.Subtotal,
		U.ICMS,
		U.Total
	FROM
		tblUEPS AS U
	JOIN
		tblMovimentação AS M
	ON
		U.idMovimentacao = M.idMovimentacao
	GROUP BY
		U.DataEntrada,
		M.Desc_Mov,
		U.Numlote,
		U.Descricao,
		U.Qtde,
		U.PrecoUnit,
		U.DataSaida,
		U.Subtotal,
		U.ICMS,
		U.Total



GO
/****** Object:  View [dbo].[uvwUsuarioNivelAcesso]    Script Date: 03/12/2015 10:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[uvwUsuarioNivelAcesso]

AS
	SELECT 
		U.Nome AS NOME,
		U.Senha AS SENHA,
		U.Email AS EMAIL,
		U.idNivel AS idAcesso,
		NV.Descricao AS NIVELACESSO
	FROM 
		tblUsuario AS U
	JOIN
		tblNivelAcesso AS NV
	ON
		U.idNivel = NV.idNivel



GO
ALTER TABLE [dbo].[tblCustoMedio]  WITH CHECK ADD  CONSTRAINT [FK_tblCusotMedio_tblMovimentação] FOREIGN KEY([idMovimentacao])
REFERENCES [dbo].[tblMovimentação] ([idMovimentacao])
GO
ALTER TABLE [dbo].[tblCustoMedio] CHECK CONSTRAINT [FK_tblCusotMedio_tblMovimentação]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblFornecedor] FOREIGN KEY([idFornecedor])
REFERENCES [dbo].[tblFornecedor] ([id])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblFornecedor]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblMovimentação] FOREIGN KEY([idMovimentacao])
REFERENCES [dbo].[tblMovimentação] ([idMovimentacao])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblMovimentação]
GO
ALTER TABLE [dbo].[tblPEPS]  WITH CHECK ADD  CONSTRAINT [FK_tblPEPS_tblMovimentação] FOREIGN KEY([idMovimentacao])
REFERENCES [dbo].[tblMovimentação] ([idMovimentacao])
GO
ALTER TABLE [dbo].[tblPEPS] CHECK CONSTRAINT [FK_tblPEPS_tblMovimentação]
GO
ALTER TABLE [dbo].[tblUEPS]  WITH CHECK ADD  CONSTRAINT [FK_tblUEPS_tblMovimentação] FOREIGN KEY([idMovimentacao])
REFERENCES [dbo].[tblMovimentação] ([idMovimentacao])
GO
ALTER TABLE [dbo].[tblUEPS] CHECK CONSTRAINT [FK_tblUEPS_tblMovimentação]
GO
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblNivelAcesso] FOREIGN KEY([idNivel])
REFERENCES [dbo].[tblNivelAcesso] ([idNivel])
GO
ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblNivelAcesso]
GO
USE [master]
GO
ALTER DATABASE [ControleEstoque] SET  READ_WRITE 
GO
