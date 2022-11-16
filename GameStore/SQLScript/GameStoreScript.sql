USE [GameStoreDatabase]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 16/11/2022 17:09:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Platform] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Games] ON 

INSERT [dbo].[Games] ([Id], [Name], [Platform], [Price]) VALUES (1, N'God of War Ragnarok', N'PlayStation 5', CAST(199.99 AS Decimal(18, 2)))
INSERT [dbo].[Games] ([Id], [Name], [Platform], [Price]) VALUES (2, N'Elden Ring', N'PC, Xbox Series X, PlayStation 5', CAST(159.99 AS Decimal(18, 2)))
INSERT [dbo].[Games] ([Id], [Name], [Platform], [Price]) VALUES (1003, N'Call of Duty: Modern Warfare 2', N'PC, Xbox Series X, Playstation 5', CAST(214.99 AS Decimal(18, 2)))
INSERT [dbo].[Games] ([Id], [Name], [Platform], [Price]) VALUES (2002, N'FIFA 23', N'PC, Xbox Series X, PlayStation 5', CAST(299.99 AS Decimal(18, 2)))
INSERT [dbo].[Games] ([Id], [Name], [Platform], [Price]) VALUES (2003, N'Marvel''s Spider Man: Miles Morales', N'PC, Xbox Series X, PlayStation 5', CAST(199.99 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Games] OFF
GO
