CREATE PROCEDURE uspCadastrarCategoria
	@Descricao AS VARCHAR(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			IF(EXISTS(SELECT * FROM tblTipo WHERE Descricao = @Descricao))
				RAISERROR('Categoria já existe !',14,1);

			INSERT INTO tblTipo
			(
				Descricao
			)
			VALUES
			(
				@Descricao
			)

			SELECT @@IDENTITY AS Retorno

		COMMIT TRAN
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	
	END CATCH
END