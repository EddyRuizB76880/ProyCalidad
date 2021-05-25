CREATE TABLE [dbo].[Product_Photos] (
    [Product_Photos_ID] INT             NULL,
    [Photos]            VARBINARY (MAX) NULL,
    FOREIGN KEY ([Product_Photos_ID]) REFERENCES [dbo].[Product] ([Code_ID])
);

