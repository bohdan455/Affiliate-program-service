CREATE PROCEDURE [dbo].[spUser_GetSubsсribedAffiliatePrograms]
	@Id int
AS
BEGIN
	SELECT ap.Id,ap.Title,ap.[Description]
	FROM [User] as u
	LEFT JOIN UserSubscriptions as us
	ON u.Id = us.UserId
	LEFT JOIN AffiliateProgram as ap
	ON us.AffiliateProgramId = ap.Id
	WHERE u.Id = @Id
END
