USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspDescricaoCategoriaQtde]    Script Date: 10/11/2015 19:02:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspDescricaoCategoriaQtde]
AS
BEGIN

		SELECT
			DISTINCT (E.Descricao) AS Descrição_Item,
			T.Descricao AS Categoria_Item,
			MIN(E.DataEntrada) AS Menor_Data_Entrada,
			MAX(E.DataEntrada) AS Maior_Data_Entrada,
			SUM(E.Qtde) AS Qtde_Disponivel,
			AVG(PrecoUnit) as Media_Preco
		FROM
			tblEstoque AS E
		JOIN
			tblTipo AS T
		ON
			E.idTipo = T.id
		WHERE
			Qtde > 0
		GROUP BY 
			E.Descricao,
			T.Descricao

END