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

MERGE INTO Province AS TARGET
USING (VALUES
	('Heredia'),
	('Cartago'),
	('Puntarenas'),
	('Guanacaste'),
	('Limón'),
	('Alajuela'),
	('San José')
)
AS Source ([Name])
ON TARGET.Name = Source.Name
WHEN NOT MATCHED BY TARGET THEN
INSERT (Name)
VALUES (Name);