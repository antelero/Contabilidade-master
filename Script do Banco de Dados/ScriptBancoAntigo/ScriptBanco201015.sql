USE [master]
GO
/****** Object:  Database [ControleEstoque]    Script Date: 20/10/2015 12:44:02 ******/
CREATE DATABASE [ControleEstoque]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ControleEstoque', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ControleEstoque.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ControleEstoque_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\ControleEstoque_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ControleEstoque] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ControleEstoque].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ControleEstoque] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ControleEstoque] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ControleEstoque] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ControleEstoque] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ControleEstoque] SET ARITHABORT OFF 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ControleEstoque] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ControleEstoque] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ControleEstoque] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ControleEstoque] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ControleEstoque] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ControleEstoque] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ControleEstoque] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ControleEstoque] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ControleEstoque] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ControleEstoque] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ControleEstoque] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ControleEstoque] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ControleEstoque] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ControleEstoque] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ControleEstoque] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ControleEstoque] SET  MULTI_USER 
GO
ALTER DATABASE [ControleEstoque] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ControleEstoque] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ControleEstoque] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ControleEstoque] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ControleEstoque]
GO
/****** Object:  StoredProcedure [dbo].[uspFornecedorInserir]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspFornecedorInserir]
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
GO
/****** Object:  StoredProcedure [dbo].[uspProdutoInserir]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspProdutoInserir]
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
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioCadastrar]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioCadastrar]
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

			IF(EXISTS(SELECT * FROM tblUsuario WHERE Senha = @Senha))
				RAISERROR('Senha já existe', 14,1);
				
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

				SELECT @@IDENTITY AS Retorno;

		COMMIT TRAN
	END TRY
	BEGIN CATCH

		ROLLBACK TRAN
		SELECT ERROR_MESSAGE() AS Retorno
	
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[uspUsuarioValidar]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspUsuarioValidar]
	@Nome VARCHAR(50),
	@Senha VARCHAR(50)
AS
BEGIN
	DECLARE @idNivel int
	DECLARE @msg varchar(24)

	IF(NOT EXISTS(SELECT * FROM uvwUsuarioNivelAcesso AS AC WHERE AC.NOME = @Nome AND AC.SENHA = @Senha))
		BEGIN
			SET @msg = 'NOME OU SENHA INVALIDO'
			SELECT @msg AS Mensagem
		END
	ELSE
		BEGIN 
			SET @idNivel = (SELECT AC.idAcesso FROM uvwUsuarioNivelAcesso AS AC WHERE AC.NOME = @Nome AND AC.SENHA = @Senha)
			SELECT @idNivel AS NivelAcesso
		END
END
GO
/****** Object:  Table [dbo].[tblEstoque]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEstoque](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[idTipo] [int] NOT NULL,
	[Qtde] [int] NOT NULL,
	[PrecoUnit] [decimal](18, 2) NOT NULL,
	[DataEntrada] [date] NOT NULL,
	[idFornecedor] [int] NOT NULL,
 CONSTRAINT [PK_tblEstoque] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblFornecedor]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFornecedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NomeFantasia] [varchar](50) NOT NULL,
	[Cnpj] [varchar](14) NOT NULL,
 CONSTRAINT [PK_tblFornecedor_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNivelAcesso]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNivelAcesso](
	[idNivel] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblNivelAcesso] PRIMARY KEY CLUSTERED 
(
	[idNivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTipo]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTipo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblTipo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[SobreNome] [varchar](50) NOT NULL,
	[DataNascimento] [date] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Senha] [varchar](50) NOT NULL,
	[idNivel] [int] NOT NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[uvwConsultarDescricaoCategoria]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[uvwConsultarDescricaoCategoria]

AS
	SELECT 
		E.Descricao AS Bebida,
		T.Descricao AS Categoria,
		E.PrecoUnit AS Preco,
		E.Qtde AS Quantidade
	FROM
		tblEstoque AS E
	JOIN
		tblTipo AS T
	ON
		E.idTipo = T.id


GO
/****** Object:  View [dbo].[uvwUsuarioNivelAcesso]    Script Date: 20/10/2015 12:44:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[uvwUsuarioNivelAcesso]

AS
	SELECT 
		tblUsuario.Nome AS NOME,
		tblUsuario.Senha AS SENHA,
		tblNivelAcesso.idNivel AS idAcesso,
		tblNivelAcesso.Descricao AS NIVELACESSO
	FROM 
		tblUsuario
	JOIN
		tblNivelAcesso
	ON
		tblUsuario.idNivel = tblNivelAcesso.idNivel


GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblFornecedor] FOREIGN KEY([idFornecedor])
REFERENCES [dbo].[tblFornecedor] ([id])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblFornecedor]
GO
ALTER TABLE [dbo].[tblEstoque]  WITH CHECK ADD  CONSTRAINT [FK_tblEstoque_tblTipo] FOREIGN KEY([idTipo])
REFERENCES [dbo].[tblTipo] ([id])
GO
ALTER TABLE [dbo].[tblEstoque] CHECK CONSTRAINT [FK_tblEstoque_tblTipo]
GO
ALTER TABLE [dbo].[tblUsuario]  WITH CHECK ADD  CONSTRAINT [FK_tblUsuario_tblNivelAcesso] FOREIGN KEY([idNivel])
REFERENCES [dbo].[tblNivelAcesso] ([idNivel])
GO
ALTER TABLE [dbo].[tblUsuario] CHECK CONSTRAINT [FK_tblUsuario_tblNivelAcesso]
GO
USE [master]
GO
ALTER DATABASE [ControleEstoque] SET  READ_WRITE 
GO
