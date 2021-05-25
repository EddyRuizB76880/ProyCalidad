CREATE TABLE [dbo].[Members] (
    [User_Email] VARCHAR (100) NOT NULL,
    [Score]      INT           NULL,
    [Lat]        FLOAT (53)    NULL,
    [Long]       FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([User_Email] ASC),
    CONSTRAINT [FK_Members_User] FOREIGN KEY ([User_Email]) REFERENCES [dbo].[User] ([Email]) ON DELETE CASCADE ON UPDATE CASCADE
);

