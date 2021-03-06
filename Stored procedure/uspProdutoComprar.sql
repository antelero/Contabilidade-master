USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoComprar]    Script Date: 18/11/2015 21:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspProdutoComprar]
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