CREATE TABLE [dbo].[Product_Service] (
    [Code_ID]             INT           NOT NULL,
    [Product_Description] VARCHAR (220) NULL,
    [Category_Id]      Int  NOT NULL,
    [Entrepreneur_Email]  VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Code_ID] ASC),
    FOREIGN KEY ([Category_Id]) REFERENCES [dbo].[Category] ([Id])
);



