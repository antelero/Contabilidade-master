USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioCadastrar]    Script Date: 26/11/2015 14:08:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspUsuarioCadastrar]
	@Nome AS VARCHAR(50),
	@SobreNome AS VARCHAR(50),
	@DataNascimento AS DATE,
	@Email AS VARCHAR(50),
	@Senha AS VARCHAR(50),
	@idNivel AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			IF(EXISTS(SELECT * FROM tblUsuario WHERE Senha = @Senha ))
			BEGIN
				RAISERROR('Usuário e Senha já existe', 14,1);
			END
			ELSE
			BEGIN
				INSERT INTO tblUsuario
				(
					Nome,
					SobreNome,
					DataNascimento,
					Email,
					Senha,
					idNivel
				)
				VALUES
				(
					UPPER(@Nome),
					UPPER(@SobreNome),
					@DataNascimento,
					@Email,
					@Senha,
					@idNivel
				)
				
				COMMIT TRAN
				SELECT @@IDENTITY AS Retorno;
			END
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	
	END CATCH
END