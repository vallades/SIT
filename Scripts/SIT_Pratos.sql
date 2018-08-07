USE [MelhorPrecoSempreIT]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SIT_Pratos](
	[PratoId] [int] IDENTITY(1,1) NOT NULL,
	[NomeRestaurante] [varchar](60) NOT NULL,
	[NomePrato] [varchar](60) NOT NULL,
	[DescricaoPrato] [varchar](250) NOT NULL,
	[ValorPratoDe] [money] NOT NULL,
	[ValorPratoPara] [money] NOT NULL,
	[Ativo] bit NOT NULL
  )
  ON "default"
GO
ALTER TABLE SIT_Pratos ADD CONSTRAINT SIT_Pratos_PK PRIMARY KEY CLUSTERED (PratoId)
WITH
  (
    ALLOW_PAGE_LOCKS = ON ,
    ALLOW_ROW_LOCKS  = ON
  )
  ON "default"
GO

INSERT INTO SIT_Pratos VALUES ('Bar do Zé', 'Bife acebolado', 'Arroz, Feijão, Fritas ou Salada, acompanhado de um delicioso contra-filé acebolado', 16.90, 16.90, 1)
INSERT INTO SIT_Pratos VALUES ('Bar do Mathias', 'Bife a Milanesa', 'Arroz, Feijão, Fritas, acompanhado de um delicioso contra-filé a milanesa', 22.90, 22.90, 1)
INSERT INTO SIT_Pratos VALUES ('Bar do Mathias', 'lazagna', 'Arroz e Lazagna', 33.90, 33.90, 1)
INSERT INTO SIT_Pratos VALUES ('Bar do João Paulo', 'Lanche Gourmet', 'Pão, maionese e hamburger caseiro, com deliciosa alface americana fresquinha acompanhado de uma porção de fritas sob medida da sua fome', 40.00, 40.00, 1)