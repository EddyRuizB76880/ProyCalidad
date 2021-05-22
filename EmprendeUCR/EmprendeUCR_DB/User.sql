﻿CREATE TABLE [dbo].[User]
(
	[Email] VARCHAR(20) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(15) NULL,
	[FLastName] VARCHAR(15) NULL,
	[SLastName] VARCHAR(15) NULL,
	[Photo] VARBINARY(8000) NULL,
	[BirthDate] DATE NULL,
	[ProvinceName] VARCHAR(15) NULL,
	[CantonName] VARCHAR(15) NULL,
	[DistrictName] VARCHAR(15) NULL,
	CONSTRAINT [FK_User_Province] FOREIGN KEY ([ProvinceName]) REFERENCES [Province]([Name]) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [FK_User_Canton] FOREIGN KEY ([CantonName]) REFERENCES [Canton]([Name]) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT [FK_User_District] FOREIGN KEY ([DistrictName]) REFERENCES [District]([Name]) ON DELETE CASCADE ON UPDATE CASCADE,
)
