CREATE PROCEDURE [dbo].[spUser_SubscribeToAffiliateProgram]
	@UserId int,
	@AffiliateProgramId int
AS
BEGIN
	INSERT INTO UserSubscriptions(UserId,AffiliateProgramId)
	VALUES ( @UserId,@AffiliateProgramId )
END
