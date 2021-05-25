CREATE TABLE [dbo].[Likes] (
    [Client_Email]   VARCHAR (100) NOT NULL,
    [Category_Title] VARCHAR (30)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Client_Email] ASC)
);

