USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspFazerBuscaEstoqueUEPS]    Script Date: 20/11/2015 15:34:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspFazerBuscaEstoqueUEPS]
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