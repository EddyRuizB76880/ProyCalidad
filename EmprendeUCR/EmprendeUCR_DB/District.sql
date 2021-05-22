CREATE TABLE [dbo].[District]
(
	[Name] VARCHAR(15) NOT NULL,
	[ProvinceName] VARCHAR (15) NOT NULL, 
	[CantonName] VARCHAR (15) NOT NULL, 
	PRIMARY KEY ([Name],[ProvinceName],[CantonName]),
	CONSTRAINT [FK_District_Canton] FOREIGN KEY ([ProvinceName],[CantonName]) REFERENCES [Canton]([ProvinceName],[Name]) ON DELETE CASCADE ON UPDATE CASCADE
)
