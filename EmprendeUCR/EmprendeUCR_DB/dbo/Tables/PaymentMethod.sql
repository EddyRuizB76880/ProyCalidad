CREATE TABLE [dbo].[PaymentMethod] (
    [Name]   VARCHAR (30) NOT NULL,
    [Status] BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Name] ASC)
);

