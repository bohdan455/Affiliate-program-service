CREATE PROCEDURE [dbo].[spUser_Insert]
	@Email varchar(255),
	@Name nvarchar(255)
AS
BEGIN
	INSERT INTO [User](Email,[Name])
	VALUES (@Email,@Name)
END
