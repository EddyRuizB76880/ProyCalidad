CREATE TABLE [dbo].[Product]
(
    [Code_ID] INT  IDENTITY(1,1),
    [Name] NVARCHAR (50) NOT NULL,
    [Price] INT NOT NULL,
    [Product_Description] NVARCHAR(220) NULL,
    [Entrepreneur_Email] NVARCHAR(50) NOT NULL,
    PRIMARY KEY CLUSTERED([Code_ID] ASC),
    Foreign key ([Entrepreneur_Email]) REFERENCES Entrepreneur ([Email])
)
