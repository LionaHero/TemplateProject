﻿CREATE TABLE [dom].[Gender]
(
	[Id] INT NOT NULL IDENTITY(1, 1),
	[Name] NVARCHAR(MAX),

	CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED ([Id])
)
