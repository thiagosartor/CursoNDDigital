CREATE TABLE [dbo].[Aluno] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Nome]     VARCHAR (255)  NULL,
    [Email]    VARCHAR (255)  NULL,
    [Telefone] VARCHAR (10)   NULL,
    [Altura]   NUMERIC (3, 2) NULL,
    [Aprovado] TINYINT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);