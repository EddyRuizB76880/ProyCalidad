CREATE TABLE [dbo].[Credentials]
(
	[User_Email] NVARCHAR(20) Primary Key NOT NULL,

	[Password] VARCHAR(20) NOT NULL, 
    CONSTRAINT [FK_Credentials_User] FOREIGN KEY ([User_Email]) REFERENCES [User]([Email]) ON DELETE CASCADE ON UPDATE CASCADE
)
