CREATE TRIGGER utrEstoqueCompra

ON tblEstoque 

FOR INSERT
AS
BEGIN
	
	DECLARE
		@idMovimentacao AS INT,
		@NumLote AS INT,
		@Descricao AS VARCHAR(50),
		@Qtde AS INT,
		@PrecoUnit AS DECIMAL(18,2),
		@DataEntrada AS DATETIME

		SELECT
			@idMovimentacao = idMovimentacao,
			@NumLote = NumLote,
			@Descricao	= Descricao,
			@Qtde = Qtde,
			@PrecoUnit = PrecoUnit, 
			@DataEntrada = DataEntrada
		FROM
			INSERTED

		INSERT INTO tblPEPS
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal
		)
		VALUES
		(
			@idMovimentacao,
			@NumLote,
			@Descricao,
			@Qtde,
			@PrecoUnit,
			@DataEntrada,
			NULL,
			@Qtde * @PrecoUnit
		)
			
END