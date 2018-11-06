CREATE TABLE [dbo].[Conservative] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (MAX) NOT NULL,
    [Surname]       NVARCHAR (MAX) NOT NULL,
    [Age] NVARCHAR(MAX)            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

