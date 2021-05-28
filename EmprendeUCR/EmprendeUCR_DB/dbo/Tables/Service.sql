CREATE TABLE [dbo].[Service] (
    [Code_ID]             INT           NOT NULL,
    [Service_Description] VARCHAR (220) NULL,
    [Price_per_hour]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Code_ID] ASC),
    FOREIGN KEY ([Code_ID]) REFERENCES [dbo].[Product_Service] ([Code_ID])
);

