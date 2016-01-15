USE [ControleEstoque]
GO

/****** Object:  View [dbo].[uvwEstoqueUEPSCarregar]    Script Date: 21/11/2015 14:51:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER VIEW [dbo].[uvwEstoqueUEPSCarregar]
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


