﻿CREATE TABLE [dbo].[Card_PI] (
    [Account_Number]      VARCHAR (22) NOT NULL,
    [Name_Payment_Method] VARCHAR (30) NOT NULL,
    [Payment_Info_ID]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Account_Number] ASC),
<<<<<<< HEAD:EmprendeUCR/EmprendeUCR_DB/dbo/Tables/Card_PI.sql
    FOREIGN KEY ([Name_Payment_Method]) REFERENCES [dbo].[CARD_PM] ([Name]) ON DELETE CASCADE,
=======
    FOREIGN KEY ([Name_Payment_Method]) REFERENCES [dbo].[Card_PM] ([Name]) ON DELETE CASCADE,
>>>>>>> Develop:EmprendeUCR/DB_Test/dbo/Tables/Card_PI.sql
    FOREIGN KEY ([Payment_Info_ID]) REFERENCES [dbo].[Payment_Info] ([ID]) ON DELETE CASCADE
);
