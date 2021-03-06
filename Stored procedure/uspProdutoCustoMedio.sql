USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoCustoMedio]    Script Date: 21/11/2015 15:07:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspProdutoCustoMedio]
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