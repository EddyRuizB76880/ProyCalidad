CREATE TABLE [dbo].[User]
(
	[Email] VARCHAR(100) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(15) NULL,
	[FLastName] VARCHAR(15) NULL,
	[SLastName] VARCHAR(15) NULL,
	[Photo] VARBINARY(8000) NULL,
	[BirthDate] DATE NULL,
	[ProvinceName] VARCHAR(15) NULL,
	[CantonName] VARCHAR(15) NULL,
	[DistrictName] VARCHAR(15) NULL,
	CONSTRAINT [FK_User_District] FOREIGN KEY ([DistrictName],[ProvinceName],[CantonName]) REFERENCES [District]([Name],[ProvinceName],[CantonName]) ON DELETE CASCADE ON UPDATE CASCADE,
)
