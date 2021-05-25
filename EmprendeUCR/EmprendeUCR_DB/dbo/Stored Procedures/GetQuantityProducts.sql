CREATE PROCEDURE [dbo].[GetQuantityProducts]  
@quantity INT OUTPUT 

AS BEGIN 
	SELECT @quantity = count(*) 
	FROM Product p
END