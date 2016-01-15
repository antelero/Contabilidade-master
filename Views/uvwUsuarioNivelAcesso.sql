USE [ControleEstoque]
GO

/****** Object:  View [dbo].[uvwUsuarioNivelAcesso]    Script Date: 22/10/2015 01:59:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER VIEW [dbo].[uvwUsuarioNivelAcesso]

AS
	SELECT 
		U.Nome AS NOME,
		U.Senha AS SENHA,
		U.Email AS EMAIL,
		U.idNivel AS idAcesso,
		NV.Descricao AS NIVELACESSO
	FROM 
		tblUsuario AS U
	JOIN
		tblNivelAcesso AS NV
	ON
		U.idNivel = NV.idNivel


GO


