CREATE PROCEDURE [dbo].[spAffiliateProgram_GetAll]
AS
BEGIN
	SELECT Id,Title,[Description]
	FROM AffiliateProgram

END
