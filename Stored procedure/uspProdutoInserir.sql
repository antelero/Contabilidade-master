USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoInserir]    Script Date: 20/10/2015 03:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspProdutoInserir]
	@Descricao AS VARCHAR(50),
	@idTipo AS INT,
	@Qtde AS INT,
	@PrecoUnit AS DECIMAL(18,2),
	@idFornecedor AS INT
AS
BEGIN
	INSERT INTO tblEstoque
	(
		Descricao,
		idTipo,
		Qtde,
		PrecoUnit,
		DataEntrada,
		idFornecedor
	)
	VALUES
	(
		UPPER(@Descricao),
		@idTipo,
		@Qtde,
		@PrecoUnit,
		GETDATE(),
		@idFornecedor
	)

	SELECT @@IDENTITY AS Retorno
END