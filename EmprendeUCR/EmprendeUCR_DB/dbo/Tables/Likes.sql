CREATE TABLE [dbo].[Likes] (
    [Client_Email]   VARCHAR (100) NOT NULL,
	[Category_Id]	INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Client_Email] ASC, [Category_Id] ASC),
    CONSTRAINT [FK_Likes_Email] FOREIGN KEY ([Client_Email]) REFERENCES [dbo].[Client] ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Likes_Category] FOREIGN KEY ([Category_Id]) REFERENCES [dbo].[Category] ON DELETE CASCADE ON UPDATE CASCADE
);