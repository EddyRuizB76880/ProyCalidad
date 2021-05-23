CREATE TABLE [dbo].[Product]
(
    [Code_ID] INT  IDENTITY(1,1),
    [Name] NVARCHAR (50) NOT NULL,
    [Price] INT NOT NULL,
    PRIMARY KEY CLUSTERED([Code_ID] ASC)
)
