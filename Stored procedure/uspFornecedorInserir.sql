USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorInserir]    Script Date: 20/10/2015 03:05:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspFornecedorInserir]
	@NomeFantasia AS VARCHAR(50),
	@Cnpj AS VARCHAR(14)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			IF(EXISTS(SELECT * FROM tblFornecedor WHERE Cnpj = @Cnpj))
				RAISERROR('Fornecedor já existe !',14,1);

			INSERT INTO tblFornecedor
			(
				NomeFantasia,
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