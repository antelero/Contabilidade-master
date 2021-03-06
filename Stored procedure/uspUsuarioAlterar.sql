USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioAlterar]    Script Date: 12/01/2016 16:24:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspUsuarioAlterar]
	@idUsuario as int,
	@Nome AS VARCHAR(50),
	@SobreNome AS VARCHAR(50),
	@DataNascimento AS DATETIME,
	@Email AS VARCHAR(50),
	@Senha AS VARCHAR(50),
	@NivelAcesso AS INT
AS
BEGIN
	--VALIDAR SE USUARIO EXISTE
	IF(EXISTS(SELECT * FROM tblUsuario AS U WHERE U.idUsuario = @idUsuario))
	BEGIN
		UPDATE	tblUsuario
		SET		Nome = @Nome,
				SobreNome = @SobreNome,
				DataNascimento = @DataNascimento,
				Email = @Email,
				Senha = @Senha,
				idNivel = @NivelAcesso
		WHERE	idUsuario = @idUsuario

		SELECT @idUsuario AS Retorno
	END
	ELSE
		SELECT 0 AS Retorno
END