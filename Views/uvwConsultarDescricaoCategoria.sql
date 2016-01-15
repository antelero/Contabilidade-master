USE [ControleEstoque]
GO

/****** Object:  View [dbo].[uvwConsultarDescricaoCategoria]    Script Date: 18/10/2015 02:04:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[uvwConsultarDescricaoCategoria]

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


