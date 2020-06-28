SET IDENTITY_INSERT [dbo].[DomainHost] ON
INSERT INTO [dbo].[DomainHost] ([Id], [Name], [DomainTypes]) VALUES (1, N'Go daddy ', N'.com, .org')
INSERT INTO [dbo].[DomainHost] ([Id], [Name], [DomainTypes]) VALUES (2, N'Verisign ', N'.net, .com ')
SET IDENTITY_INSERT [dbo].[DomainHost] OFF
SET IDENTITY_INSERT [dbo].[Domain] ON
INSERT INTO [dbo].[Domain] ([Id], [DomainName], [ContactPhone], [DomainHostId]) VALUES (1, N'www.sales.com', N'0215556789', 1)
INSERT INTO [dbo].[Domain] ([Id], [DomainName], [ContactPhone], [DomainHostId]) VALUES (2, N'www.virtualmachines.net', N'0216667890', 2)
SET IDENTITY_INSERT [dbo].[Domain] OFF
SET IDENTITY_INSERT [dbo].[Owner] ON
INSERT INTO [dbo].[Owner] ([Id], [OwnerName], [ContactPhone]) VALUES (1, N'Jay Wilson', N'021555567890')
INSERT INTO [dbo].[Owner] ([Id], [OwnerName], [ContactPhone]) VALUES (2, N'Cameron Dias', N'0215556789')
SET IDENTITY_INSERT [dbo].[Owner] OFF
SET IDENTITY_INSERT [dbo].[Ownership] ON
INSERT INTO [dbo].[Ownership] ([Id], [OwnerId], [DomainId]) VALUES (1, 1, 1)
INSERT INTO [dbo].[Ownership] ([Id], [OwnerId], [DomainId]) VALUES (2, 2, 2)
SET IDENTITY_INSERT [dbo].[Ownership] OFF
