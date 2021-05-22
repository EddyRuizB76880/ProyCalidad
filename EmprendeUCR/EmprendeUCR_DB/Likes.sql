﻿CREATE TABLE [dbo].[Likes]
(
	[Client_Email]   VARCHAR(20) NOT NULL PRIMARY KEY,
	[CategoryTitle]  VARCHAR(50) NOT NULL
	CONSTRAINT FK_Category FOREIGN KEY (CategoryTitle) REFERENCES Category(Title)
)
