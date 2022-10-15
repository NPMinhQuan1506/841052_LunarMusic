CREATE PROCEDURE [dbo].[spGetWorks]
	@pId int = Null
AS
	SELECT * FROM Work WHERE Id is Null OR Id = @pId
RETURN 0
