CREATE PROCEDURE uspCategoriaCadastrar
	@Descricao AS VARCHAR(50)
AS
BEGIN
	INSERT INTO tblTipo
	(
		Descricao
	)
	VALUES
	(
		@Descricao
	)

	SELECT @@IDENTITY AS Retorno
END