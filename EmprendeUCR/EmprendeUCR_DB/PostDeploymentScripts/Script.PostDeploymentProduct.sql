/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO Product AS Target 
USING (VALUES 
    (1, 'Empanada', 500), 
    (2, 'Coca', 1000),
    (3, 'Confite', 50) 
    ) 
AS Source ([Code_ID], [Name], [Price]) ON Target.[Code_ID] = Source.[Code_ID] 
WHEN NOT MATCHED BY TARGET THEN 
INSERT ([Name], [Price]) VALUES ([Name], [Price]);

