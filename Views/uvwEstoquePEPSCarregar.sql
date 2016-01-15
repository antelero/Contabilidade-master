USE [ControleEstoque]
GO

/****** Object:  View [dbo].[uvwEstoquePEPSCarregar]    Script Date: 21/11/2015 14:48:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER VIEW [dbo].[uvwEstoquePEPSCarregar]
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


