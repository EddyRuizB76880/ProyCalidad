CREATE TABLE [dbo].[User]
(
	[Email] VARCHAR(100) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(15) NULL,
	[F_Last_Name] VARCHAR(15) NULL,
	[S_Last_Name] VARCHAR(15) NULL,
	[Photo] VARBINARY(8000) NULL,
	[Birth_Date] DATE NULL,
	[Province_Name] VARCHAR(15) NULL,
	[Canton_Name] VARCHAR(15) NULL,
	[District_Name] VARCHAR(15) NULL,
	CONSTRAINT [FK_User_District] FOREIGN KEY ([District_Name],[Province_Name],[Canton_Name]) REFERENCES [District]([Name],[Province_Name],[Canton_Name]) ON DELETE CASCADE ON UPDATE CASCADE,
)
