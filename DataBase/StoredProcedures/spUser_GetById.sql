CREATE PROCEDURE [dbo].[spUser_GetById]
	@Id int
AS
BEGIN
	SELECT Id,Email,[Name]
	FROM [User]
	WHERE Id = @Id
END
