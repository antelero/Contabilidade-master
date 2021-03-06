USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspAlterarAcesso]    Script Date: 21/11/2015 23:40:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspAlterarAcesso]

	@SenhaAtual AS VARCHAR(50),
	@NovaSenha  AS VARCHAR(50)

AS
BEGIN
	IF(NOT EXISTS(SELECT U.Senha FROM tblUsuario AS U WHERE Senha = @SenhaAtual))
		RAISERROR('SENHA ATUAL INVÁLIDA', 14,1)
	ELSE
		BEGIN

			UPDATE	tblUsuario
			SET		Senha = @NovaSenha
			WHERE	Senha = @SenhaAtual

			SELECT 1 AS Retorno
		END
END