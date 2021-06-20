CREATE TABLE [dbo].[Email_Confirmation]
(
	[Email] VARCHAR(100) NOT NULL PRIMARY KEY, 
    [Hash_Code] VARCHAR (250) NULL,
	[Creation_Date] DATE,
    [Expiration_Date] DATE, 
    CONSTRAINT [FK_Email] FOREIGN KEY ([Email]) REFERENCES [dbo].[User] ([Email]) ON DELETE CASCADE ON UPDATE CASCADE
)
