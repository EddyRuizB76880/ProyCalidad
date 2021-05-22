CREATE TABLE [dbo].[Phones]
(
    [User_Email] VARCHAR(50) Primary Key NOT NULL, 
    [Phone_Number] NVARCHAR(8) NOT NULL,
    CONSTRAINT [FK_Phones_User] FOREIGN KEY ([User_Email]) REFERENCES [User]([Email]) ON DELETE CASCADE ON UPDATE CASCADE
 
)
