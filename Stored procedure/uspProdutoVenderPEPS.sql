USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoVenderPEPS]    Script Date: 21/11/2015 15:02:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[uspProdutoVenderPEPS]
	@NumLote AS INT,
	@Qtde AS INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			
			DECLARE
				@QtdeEstoque AS INT,
				@Desc AS VARCHAR(50),
				@IdMov AS INT,
				@PrecoUnit AS DECIMAL(18,2),
				@DataEntrada AS DATETIME, 
				@Result AS DECIMAL(18,2),
				@MenorData AS DATETIME,
				@QtdeUEPS AS INT

				SET @QtdeUEPS = @Qtde

				SET @Desc = (SELECT E.Descricao FROM tblPEPS AS E WHERE NumLote = @NumLote AND idMovimentacao =1)
				SET @QtdeEstoque = (SELECT SUM(E.Qtde) FROM tblEstoque AS E WHERE /*NumLote = @NumLote AND*/ idMovimentacao = 1 AND Qtde > 0)				 
				SET @IdMov = (SELECT E.idMovimentacao FROM tblPEPS AS E WHERE NumLote = @NumLote AND idMovimentacao = 1)
				SET @PrecoUnit = (SELECT E.PrecoUnit FROM tblEstoque AS E WHERE NumLote = @NumLote)
				SET @DataEntrada = (SELECT E.DataEntrada FROM tblEstoque AS E WHERE NumLote = @NumLote)
				
				
				
				WHILE @Qtde > 0
				BEGIN
					IF(@QtdeEstoque < @Qtde AND @QtdeEstoque > 0)
					BEGIN
						UPDATE	tblEstoque
						SET		Qtde = Qtde - @QtdeEstoque
						WHERE	NumLote = @NumLote
					
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
							2,
							@NumLote,
							@Desc,
							@QtdeEstoque,
							@PrecoUnit,
							@DataEntrada,
							GETDATE(),
							@QtdeEstoque * @PrecoUnit,
							10,
							(@QtdeEstoque * @PrecoUnit) * 1.1
						)

						SET @Qtde = @Qtde - @QtdeEstoque
						SET @MenorData = (SELECT MIN(E.DataEntrada) FROM tblEstoque E WHERE Qtde > 0)
						SET @NumLote = (SELECT E.NumLote FROM tblEstoque AS E WHERE DataEntrada = @MenorData)
						
					END 
					ELSE

						IF(@QtdeEstoque >= @Qtde AND @QtdeEstoque > 0 AND @IdMov = 1)
				
						BEGIN	
							UPDATE	tblEstoque
							SET		Qtde = Qtde - @Qtde
							WHERE	NumLote = @NumLote

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
							2,
							@NumLote,
							@Desc,
							@Qtde,
							@PrecoUnit,
							@DataEntrada,
							GETDATE(),
							@Qtde * @PrecoUnit,
							10,
							(@Qtde * @PrecoUnit) * 1.1 
						)
						SET @Qtde = 0
						
						END 
					END

					EXEC uspProdutoVenderUEPS @Desc, @QtdeUEPS

					SELECT 0 AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		
		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END