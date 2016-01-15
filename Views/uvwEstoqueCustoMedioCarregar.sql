USE [ControleEstoque]
GO

/****** Object:  View [dbo].[uvwEstoqueCustoMedioCarregar]    Script Date: 21/11/2015 14:52:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[uvwEstoqueCustoMedioCarregar]
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


