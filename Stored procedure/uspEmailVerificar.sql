USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspEmailVerificar]    Script Date: 22/10/2015 10:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspEmailVerificar]
	@Email AS VARCHAR(50)
AS
BEGIN
	DECLARE @_email VARCHAR(50)
	DECLARE @Nome VARCHAR(50)
	DECLARE @Senha VARCHAR(50)
	DECLARE @Msg VARCHAR(23)

	IF(EXISTS(SELECT * FROM tblUsuario WHERE Email = @Email))
		BEGIN
			SET @_email = (SELECT EV.Email FROM uvwEmailValidar AS EV WHERE EV.Email = @Email)
			SET @Nome = (SELECT EV.Nome FROM uvwEmailValidar AS EV WHERE EV.Email = @Email)
			SET @Senha = (SELECT EV.Senha FROM uvwEmailValidar AS EV WHERE EV.Email = @Email)
			SELECT @_email AS EMAIL_DE_USUARIO , @Nome NOME_DE_USUARIO , @Senha AS SENHA_DE_USUARIO
		END

	ELSE
		BEGIN
			SET @Msg = 'E-MAIL NÃO ENCONTRADO !'
			SELECT @Msg AS Retorno
		END
		
END