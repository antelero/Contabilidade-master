USE [ControleEstoque]
GO
/****** Object:  Trigger [dbo].[utrEstoqueCompra]    Script Date: 21/11/2015 14:18:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[utrEstoqueCompra]

ON [dbo].[tblEstoque] 

FOR INSERT
AS
BEGIN
	
	DECLARE
		@idMovimentacao AS INT,
		@NumLote AS INT,
		@Descricao AS VARCHAR(50),
		@Qtde AS INT,
		@PrecoUnit AS DECIMAL(18,2),
		@DataEntrada AS DATETIME,

		--CUSTO MEDIO
		@TotalQtdeDisponivel AS INT,
		@TotalSubtotalDisponivel as decimal(18,2),
		@CustoMedio as decimal(18,2)

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
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			@idMovimentacao,
			@NumLote,
			@Descricao,
			@Qtde,
			@PrecoUnit,
			@DataEntrada,
			0000-00-00,
			@Qtde * @PrecoUnit,
			0,
			@Qtde * @PrecoUnit
		)

		INSERT INTO tblUEPS
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			@idMovimentacao,
			@NumLote,
			@Descricao,
			@Qtde,
			@PrecoUnit,
			@DataEntrada,
			0000-00-00,
			@Qtde * @PrecoUnit,
			0,
			@Qtde * @PrecoUnit
		)
		
		INSERT INTO tblCustoMedio
		(
			idMovimentacao,
			NumLote,
			Descricao,
			Qtde,
			PrecoUnit,
			DataEntrada,
			DataSaida,
			Subtotal,
			ICMS,
			Total
		)
		VALUES
		(
			@idMovimentacao,
			@NumLote,
			@Descricao,
			@Qtde,
			@PrecoUnit,
			@DataEntrada,
			0000-00-00,
			@Qtde * @PrecoUnit,
			0,
			@Qtde * @PrecoUnit
		)
END