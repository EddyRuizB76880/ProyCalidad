﻿CREATE TABLE [dbo].[Entrepeneaur]
(
	[User_Email] VARCHAR(100) NOT NULL PRIMARY KEY,
	[Presentation] VARCHAR(220) NULL,
	CONSTRAINT [FK_Entrepeneaur_User] FOREIGN KEY ([User_Email]) REFERENCES [User]([Email]) ON DELETE CASCADE ON UPDATE CASCADE
)
