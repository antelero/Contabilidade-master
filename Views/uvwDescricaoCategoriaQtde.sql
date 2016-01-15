USE [ControleEstoque]
GO

/****** Object:  View [dbo].[uvwDescricaoCategoriaQtde]    Script Date: 19/11/2015 01:13:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[uvwDescricaoCategoriaQtde]
AS
		SELECT
			DISTINCT (E.Descricao) AS Descrição_Item,
			T.Descricao AS Categoria_Item,
			MIN(E.DataEntrada) AS Menor_Data_Entrada,
			MAX(E.DataEntrada) AS Maior_Data_Entrada,
			SUM(E.Qtde) AS Qtde_Disponivel,
			AVG(PrecoUnit) as Media_Preco,
			F.NomeFantasia
		FROM
			tblEstoque AS E
		JOIN
			tblTipo AS T
		ON
			E.idTipo = T.id
		JOIN
			tblFornecedor AS F
		ON
			E.idFornecedor = F.id
		WHERE
			Qtde > 0
		GROUP BY 
			E.Descricao,
			T.Descricao,
			F.NomeFantasia
GO


