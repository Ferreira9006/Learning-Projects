IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Artigo]') AND type in (N'U'))
DROP TABLE [dbo].[Artigo]
GO

CREATE TABLE [dbo].[Artigo](
	[Id] [int] NOT NULL,
	[Descricao] [nvarchar](256) NULL,
	[Preco] [float] NULL,
	[DataValidade] [datetime] NULL,
	[TipoArtigo] [int] NULL,
	[Estado] [nvarchar](50) NULL, -- Campo Enum
 CONSTRAINT [PK_Artigo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Artigo] ([Id], [Descricao], [Preco], [DataValidade], [TipoArtigo], [Estado])
VALUES
	(1, 'Artigo 1', 1.65, '2026-03-15', 1, 'Ativo'),
	(2, 'Artigo 2', 23.9, '2026-03-15', 2, 'Inativo'),
	(3, 'Artigo 3', 12.2, '2026-03-15', 3, 'Ativo'),
	(4, 'Artigo 4', 13.9, '2026-03-15', 1, 'Inativo'),
	(5, 'Artigo 5', 14.2, '2027-03-15', 2, 'Ativo')
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArtigoGravar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ArtigoGravar]
GO

CREATE PROCEDURE [dbo].[ArtigoGravar]
@ID int,
@Descricao nvarchar(256),
@Preco float,
@DataValidade datetime,
@TipoArtigo int,
@Estado nvarchar(50)
AS
BEGIN
	BEGIN TRANSACTION
	IF (SELECT COUNT(*) FROM Artigo WHERE ID = @ID) = 0
		BEGIN
			INSERT INTO [Artigo] (ID, Descricao, Preco, DataValidade, TipoArtigo, Estado)
			VALUES (@ID, @Descricao, @Preco, @DataValidade, @TipoArtigo, @Estado)
		END
	ELSE
		BEGIN
			UPDATE Artigo
			SET Descricao = @Descricao, Preco = @Preco, DataValidade = @DataValidade, 
				TipoArtigo = @TipoArtigo, Estado = @Estado
			WHERE ID = @ID
		END

	IF @@ERROR <> 0
		ROLLBACK TRANSACTION
	ELSE
		COMMIT TRANSACTION
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArtigoObter]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ArtigoObter]
GO

CREATE PROCEDURE [dbo].[ArtigoObter]
@ID int
AS
BEGIN
	SELECT * FROM Artigo WHERE ID = @ID
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArtigoListar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ArtigoListar]
GO

CREATE PROCEDURE [dbo].[ArtigoListar]
AS
BEGIN
	SELECT * FROM Artigo
END
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ArtigoEliminar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ArtigoEliminar]
GO

CREATE PROCEDURE [dbo].[ArtigoEliminar]
@ID int
AS
BEGIN
	BEGIN TRANSACTION
	IF (SELECT COUNT(*) FROM Artigo WHERE ID = @ID) <> 0
		BEGIN
			DELETE FROM Artigo WHERE ID = @ID
		END

	IF @@ERROR <> 0
		ROLLBACK TRANSACTION
	ELSE
		COMMIT TRANSACTION
END
GO
