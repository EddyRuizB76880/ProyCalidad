﻿CREATE TABLE [dbo].[Entrepreneur]
(
	[User_Email] VARCHAR(100) NOT NULL PRIMARY KEY,
	[Presentation] VARCHAR(220) NULL,
	CONSTRAINT [FK_Entrepreneur_User] FOREIGN KEY ([User_Email]) REFERENCES [User]([Email]) ON DELETE CASCADE ON UPDATE CASCADE
)
