CREATE TABLE [dbo].[Makes_Report] (
    [Report_ID]  INT           NOT NULL,
    [User_Email] VARCHAR (100) NOT NULL,
    FOREIGN KEY ([Report_ID]) REFERENCES [dbo].[Report] ([ID]) ON DELETE CASCADE,
    FOREIGN KEY ([User_Email]) REFERENCES [dbo].[User] ([Email]) ON DELETE CASCADE
);

