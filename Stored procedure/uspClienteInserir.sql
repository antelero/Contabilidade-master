USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspClienteInserir]    Script Date: 26/11/2015 17:58:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspClienteInserir]	
	@NomeFantasia AS VARCHAR(50),
	@Cnpj AS VARCHAR(14)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			IF(EXISTS(SELECT * FROM tblCliente WHERE Cnpj = @Cnpj))
				RAISERROR('Fornecedor já existe !',14,1);

			INSERT INTO tblCliente
			(
				NomeCliente,
				Cnpj
			)
			VALUES
			(
				UPPER (@NomeFantasia),
				@Cnpj
			)

			SELECT @@IDENTITY AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	
	END CATCH
END