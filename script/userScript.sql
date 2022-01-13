USE [MVPDB]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26/04/2020 6:58:12 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (1, N'Hademar', CAST(N'1973-07-05' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (2, N'Reginalda', CAST(N'1971-09-27' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (3, N'Lovelle',  CAST(N'1976-11-01' AS Date),  1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (4, N'Maex', CAST(N'1976-09-28' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (5, N'Volbrecht', CAST(N'1990-07-22' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (6, N'Dietlinde', CAST(N'1986-08-26' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (7, N'Helmgard', CAST(N'1971-07-21' AS Date),  1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (8, N'Heloise',  CAST(N'1972-07-03' AS Date),  0)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (9, N'Dietra', CAST(N'1976-11-04' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (10, N'Dominik',  CAST(N'1999-11-18' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (11, N'Mangold', CAST(N'1991-06-09' AS Date),  1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (12, N'Achime ',  CAST(N'1970-01-31' AS Date), 0)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (13, N'Corbinian', CAST(N'1977-04-27' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (14, N'Burghard', CAST(N'1998-02-05' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (15, N'Burghild',  CAST(N'1970-01-14' AS Date), 1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (16, N'Fabius',  CAST(N'1996-02-23' AS Date),  1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (17, N'Balian ', CAST(N'1980-08-12' AS Date),  1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (18, N'Gerulf', CAST(N'1991-03-17' AS Date),  1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (19, N'Olf', CAST(N'1970-01-06' AS Date),  1)
INSERT [dbo].[User] ([IdUser], [Name],   [BirthDate],  [Active]) VALUES (20, N'Akelei ', CAST(N'1975-01-27' AS Date), 1)
SET IDENTITY_INSERT [dbo].[User] OFF
