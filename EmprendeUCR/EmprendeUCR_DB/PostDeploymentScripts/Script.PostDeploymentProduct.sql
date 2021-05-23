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
    (1, 'Empanada', 500, 'Descripcion 1', 'email1@dominio.com'), 
    (2, 'Coca', 1000, 'Descripcion 2', 'aaaaaa@dominio.com'),
    (3, 'Confite', 50, 'Descripcion 3', 'pikachu@dominio.com') 
    ) 
AS Source ([Code_ID], [Name], [Price], [Product_Description], [Entrepreneur_Email]) ON Target.[Code_ID] = Source.[Code_ID] 
WHEN NOT MATCHED BY TARGET THEN 
INSERT ([Name], [Price], [Product_Description], [Entrepreneur_Email]) VALUES ([Name], [Price], [Product_Description], [Entrepreneur_Email]);

MERGE INTO Entrepreneur AS Target 
USING (VALUES 
    ('email1@dominio.com', 'Paco', 'Rogriguez', 'apellido2'), 
    ('aaaaaa@dominio.com', 'Juan', 'Salas', 'apellido2'),
    ('pikachu@dominio.com', 'Carlas', 'Segura', 'apellido2') 
    ) 
AS Source ([Email], [Nombre], [Apellido1], [Apellido2]) ON Target.[Email] = Source.[Email] 
WHEN NOT MATCHED BY TARGET THEN 
INSERT ([Email], [Nombre], [Apellido1], [Apellido2]) VALUES ([Email], [Nombre], [Apellido1], [Apellido2]);
