CREATE TABLE [dbo].[Canton]
(
	[Name] VARCHAR(15) NOT NULL,
	[ProvinceName] VARCHAR (15) NOT NULL, 
	PRIMARY KEY ([ProvinceName],[Name]),
	CONSTRAINT [FK_Canton_Province] FOREIGN KEY ([ProvinceName]) REFERENCES [Province]([Name]) ON DELETE CASCADE ON UPDATE CASCADE
)
