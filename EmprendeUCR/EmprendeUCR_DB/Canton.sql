CREATE TABLE [dbo].[Canton]
(
	[Name] VARCHAR(15) NOT NULL,
	[Province_Name] VARCHAR (15) NOT NULL, 
	PRIMARY KEY ([Province_Name],[Name]),
	CONSTRAINT [FK_Canton_Province] FOREIGN KEY ([Province_Name]) REFERENCES [Province]([Name]) ON DELETE CASCADE ON UPDATE CASCADE
)
