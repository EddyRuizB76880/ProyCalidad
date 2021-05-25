CREATE TABLE [dbo].[Category] (
    [Title]       VARCHAR (30) NOT NULL,
    [Description] VARCHAR (50) NULL,
    [Id]    INT IDENTITY(1,1) NOT NULL,
    [ParentId] INT NULL, 
    PRIMARY KEY CLUSTERED ([Id]),
    FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Category] ([Id])
);

