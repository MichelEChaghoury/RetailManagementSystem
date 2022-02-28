﻿CREATE TABLE [dbo].[Product]
(
	[Id]			INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	[Name]			NVARCHAR(128) NOT NULL,
	[Description]	NVARCHAR(MAX) NOT NULL,
	[RetailPrice]	MONEY NOT NULL,
	[CreateDate]	DATETIME2 NOT NULL DEFAULT GETUTCDATE(),
	[LastModified]	DATETIME2 NOT NULL DEFAULT GETUTCDATE()
)