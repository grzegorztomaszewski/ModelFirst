CREATE TABLE [dbo].[KontaktySet] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Imie]     NVARCHAR (50) NOT NULL,
    [Nazwisko] NVARCHAR (50) NOT NULL,
    [Email]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_KontaktySet] PRIMARY KEY CLUSTERED ([Id] ASC)
);

