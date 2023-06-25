CREATE TABLE [dbo].[UserSubscriptions]
(
    [UserId] INT NOT NULL, 
    [AffiliateProgramId] INT NOT NULL,
    CONSTRAINT PK_User_AffiliateProgram PRIMARY KEY (UserId,AffiliateProgramId),
    CONSTRAINT FK_User FOREIGN KEY (UserId) REFERENCES [User](Id),
    CONSTRAINT FK_AffiliateProgram FOREIGN KEY (AffiliateProgramId) REFERENCES [AffiliateProgram](Id)
)
