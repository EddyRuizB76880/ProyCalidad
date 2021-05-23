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


MERGE INTO Canton AS TARGET 
USING (VALUES
	('San José', 'San José'),
	('Escazú', 'San José'),
	('Desamparados', 'San José'),
	('Puriscal', 'San José'),
	('Tarrazú', 'San José'),
	('Aserrí', 'San José'),
	('Mora', 'San José'),
	('Goicoechea', 'San José'),
	('Santa Ana', 'San José'),
	('Alajuelita', 'San José'),
	('Coronado', 'San José'),
	('Acosta', 'San José'),
	('Tibás', 'San José'),
	('Moravia', 'San José'),
	('Montes de Oca', 'San José'),
	('Turrubares', 'San José'),
	('Dota', 'San José'),
	('Curridabat', 'San José'),
	('Pérez Zeledón', 'San José'),
	('León Cortés', 'San José'),
	('Alajuela', 'Alajuela'),
	('San Ramón', 'Alajuela'),
	('Grecia', 'Alajuela'),
	('San Mateo', 'Alajuela'),
	('Atenas', 'Alajuela'),
	('Naranjo', 'Alajuela'),
	('Palmares', 'Alajuela'),
	('Poás', 'Alajuela'),
	('Orotina', 'Alajuela'),
	('San Carlos', 'Alajuela'),
	('Zarcero', 'Alajuela'),
	('Sarchí', 'Alajuela'),
	('Upala', 'Alajuela'),
	('Los Chiles', 'Alajuela'),
	('Guatuso', 'Alajuela'),
	('Río Cuarto', 'Alajuela'),
	('Cartago', 'Cartago'),
	('Paraíso', 'Cartago'),
	('La Unión', 'Cartago'),
	('Jiménez', 'Cartago'),
	('Turrialba', 'Cartago'),
	('Alvarado', 'Cartago'),
	('Oreamuno', 'Cartago'),
	('El Guarco', 'Cartago'),
	('Heredia', 'Heredia'),
	('Barva', 'Heredia'),
	('Santo Domingo', 'Heredia'),
	('Santa Bárbara', 'Heredia'),
	('San Rafael', 'Heredia'),
	('San Isidro', 'Heredia'),
	('Belén', 'Heredia'),
	('Flores', 'Heredia'),
	('San Pablo', 'Heredia'),
	('Sarapiquí', 'Heredia'),
	('Liberia', 'Guanacaste'),
	('Nicoya', 'Guanacaste'),
	('Santa Cruz', 'Guanacaste'),
	('Bagaces', 'Guanacaste'),
	('Carrillo', 'Guanacaste'),
	('Cañas', 'Guanacaste'),
	('Abangares', 'Guanacaste'),
	('Tilarán', 'Guanacaste'),
	('Nandayure', 'Guanacaste'),
	('La Cruz', 'Guanacaste'),
	('Hojancha', 'Guanacaste'),
	('Puntarenas', 'Puntarenas'),
	('Esparza', 'Puntarenas'),
	('Buenos Aires', 'Puntarenas'),
	('Montes de Oro', 'Puntarenas'),
	('Osa', 'Puntarenas'),
	('Quepos', 'Puntarenas'),
	('Golfito', 'Puntarenas'),
	('Coto Brus', 'Puntarenas'),
	('Parrita', 'Puntarenas'),
	('Corredores', 'Puntarenas'),
	('Garabito', 'Puntarenas'),
	('Limón', 'Limón'),
	('Pococí', 'Limón'),
	('Siquirres', 'Limón'),
	('Talamanca', 'Limón'),
	('Matina', 'Limón'),
	('Guácimo', 'Limón')


) 
AS Source ([Name], Province_Name)
ON TARGET.Name = Source.Name
WHEN NOT MATCHED BY TARGET THEN
INSERT ([Name], Province_Name)
VALUES ([Name],Province_Name);