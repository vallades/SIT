USE [MelhorPrecoSempreIT]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SIT_Usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[LoginUsuario] [varchar](60) NOT NULL,
	[SenhaUsuario] [varchar](32) NOT NULL,
	[Ativo] bit NOT NULL
  )
  ON "default"
GO
ALTER TABLE SIT_Usuarios ADD CONSTRAINT SIT_Usuarios_PK PRIMARY KEY CLUSTERED (UsuarioId)
WITH
  (
    ALLOW_PAGE_LOCKS = ON ,
    ALLOW_ROW_LOCKS  = ON
  )
  ON "default"
GO


INSERT INTO SIT_Usuarios values ('felipe', '1234567890', 1)
INSERT INTO SIT_Usuarios values ('sempreit', 'sempreit123', 1)