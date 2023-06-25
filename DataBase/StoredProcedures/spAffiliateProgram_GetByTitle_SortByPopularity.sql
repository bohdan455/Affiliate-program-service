CREATE PROCEDURE [dbo].[spAffiliateProgram_GetByTitle_SortByPopularity]
	@Term varchar(500)
AS
BEGIN
	SELECT ap.Id,ap.Title,ap.[Description]
	FROM AffiliateProgram as ap
	LEFT JOIN UserSubscriptions as us
	ON ap.Id = us.AffiliateProgramId
	WHERE Title LIKE '%'+ @Term + '%'
	GROUP BY ap.Id,ap.Title,ap.[Description]
	ORDER BY COUNT(us.UserId) DESC

	
END
 