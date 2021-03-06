USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspFazerBusca]    Script Date: 19/11/2015 01:22:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspFazerBusca]
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