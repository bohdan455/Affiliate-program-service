﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Email] VARCHAR(255) NOT NULL UNIQUE, 
    [Name] NVARCHAR(255) NOT NULL
)
