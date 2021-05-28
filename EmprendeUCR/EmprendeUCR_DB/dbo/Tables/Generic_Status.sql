﻿CREATE TABLE [dbo].[Generic_Status] (
    [Name]      VARCHAR(20)     NOT NULL,

    PRIMARY KEY CLUSTERED ([Name] ASC),
    CONSTRAINT [FK_dbo.Generic_Status_dbo.Status] FOREIGN KEY ([Name]) REFERENCES [dbo].[Status] ([Name]) ON DELETE CASCADE ON UPDATE CASCADE
);

