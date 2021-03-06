USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspExcluirUsuario]    Script Date: 22/11/2015 21:50:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspExcluirUsuario]
	@idUsuario AS INT
AS
BEGIN

	IF(NOT EXISTS(SELECT * FROM tblUsuario AS U WHERE idUsuario = @idUsuario))
		RAISERROR('USUÁRIO NÃO EXISTE !',14,1)

	DELETE FROM
			tblUsuario
	WHERE
			idUsuario = @idUsuario

	SELECT @idUsuario AS Retorno
END