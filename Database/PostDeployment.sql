SET IDENTITY_INSERT [dom].[Gender] ON
	INSERT INTO [dom].[Gender] ([Id], [Name]) VALUES(1, N'Male');
	INSERT INTO [dom].[Gender] ([Id], [Name]) VALUES(2, N'Female');
SET IDENTITY_INSERT [dom].[Gender] OFF

SET IDENTITY_INSERT [acc].[User] ON
	INSERT INTO [acc].[User] ([Id], [GenderId], [Email], [Mobile], [FirstName], [LastName], [MiddleName], [Skype], [BirthDate], [PasswordHash], [CreatedDateUtc])
		VALUES (1, 1, N'basil.kosovan@gmail.com', '+380993949848', 'Basil', 'Basil', 'Basil', 'Basil', GETUTCDATE(), 'PasswordHash', GETUTCDATE());

	INSERT INTO [acc].[User] ([Id], [GenderId], [Email], [Mobile], [FirstName], [LastName], [MiddleName], [Skype], [BirthDate], [PasswordHash], [CreatedDateUtc])
		VALUES (2, 1, N'basil.kosovan@gmail.com', '+380993949848', 'Leo', 'Leo', 'Leo', 'Leo', GETUTCDATE(), 'PasswordHash', GETUTCDATE());
SET IDENTITY_INSERT [acc].[User] OFF