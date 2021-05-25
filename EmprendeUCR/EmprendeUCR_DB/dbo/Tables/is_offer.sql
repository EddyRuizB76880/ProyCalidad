CREATE TABLE [dbo].[is_offer] (
    [Offer_ID] INT NOT NULL,
    [Code_ID]  INT NOT NULL,
    FOREIGN KEY ([Code_ID]) REFERENCES [dbo].[Product_Service] ([Code_ID]),
    FOREIGN KEY ([Offer_ID]) REFERENCES [dbo].[Offer] ([Offer_ID])
);

