USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspCarregaProdutoAntigo]    Script Date: 11/11/2015 00:48:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspCarregaProdutoAntigo]
	@Desc AS VARCHAR(50)
AS
BEGIN
	--INICIO TESTE
		DECLARE
		@Menor_Data AS DATETIME,
		@QtdeDisponivel AS INT

		SELECT @Menor_Data = MIN(DATAENTRADA)  FROM tblPEPS WHERE Descricao = @Desc AND Qtde > 0

		SELECT @QtdeDisponivel = E.Qtde FROM tblPEPS AS E WHERE Descricao = @Desc AND DataEntrada = @Menor_Data

		SELECT
			*
		FROM
			tblPEPS AS E
		WHERE
			DataEntrada = @Menor_Data AND Qtde = @QtdeDisponivel

	--FIM TESTE
	--DECLARE
	--	@Menor_Data AS DATETIME,
	--	@QtdeDisponivel AS INT

	--SELECT @Menor_Data = MIN(DATAENTRADA)  FROM tblEstoque WHERE Descricao = @Desc AND Qtde > 0

	--SELECT @QtdeDisponivel = E.Qtde FROM tblEstoque AS E WHERE Descricao = @Desc AND DataEntrada = @Menor_Data

	--SELECT
	--	*
	--FROM
	--	tblEstoque AS E
	--WHERE
	--	DataEntrada = @Menor_Data AND Qtde = @QtdeDisponivel
END