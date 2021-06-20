CREATE TABLE [dbo].[Client]
(
	[User_Email] VARCHAR(100) NOT NULL PRIMARY KEY,
	[First_Preferred_Category] VARCHAR(35),
	[Second_Preferred_Category] VARCHAR(35),
	[Third_Preferred_Category] VARCHAR(35)
	
	CONSTRAINT FK_Client_Members FOREIGN KEY (User_Email) REFERENCES Members(User_Email) ON DELETE CASCADE ON UPDATE CASCADE
)
