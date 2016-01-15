CREATE VIEW uvwEmailValidar
AS

	SELECT
		U.Nome,
		U.Senha,
		U.Email
	FROM
		tblUsuario AS U