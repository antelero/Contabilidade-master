USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspCarregaProdutoNovo]    Script Date: 10/11/2015 23:45:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspCarregaProdutoNovo]
	@Desc AS VARCHAR(50)
AS
BEGIN
	--INICIO TESTE
		DECLARE
		@Maior_Data AS DATETIME,
		@QtdeDisponivel AS INT

		SELECT @Maior_Data = MAX(DataEntrada) FROM tblUEPS WHERE Descricao = @Desc AND Qtde > 0

		SELECT @QtdeDisponivel = E.Qtde FROM tblUEPS AS E WHERE Descricao = @Desc AND DataEntrada = @Maior_Data

		SELECT
			*
		FROM
			tblUEPS AS E
		WHERE
			DataEntrada = @Maior_Data AND Qtde = @QtdeDisponivel

	--FIM TESTE
	--DECLARE
	--	@Maior_Data AS DATETIME,
	--	@QtdeDisponivel AS INT

	--SELECT @Maior_Data = MAX(DataEntrada) FROM tblEstoque WHERE Descricao = @Desc AND Qtde > 0

	--SELECT @QtdeDisponivel = E.Qtde FROM tblEstoque AS E WHERE Descricao = @Desc AND DataEntrada = @Maior_Data

	--SELECT
	--	*
	--FROM
	--	tblEstoque AS E
	--WHERE
	--	DataEntrada = @Maior_Data AND Qtde = @QtdeDisponivel
END