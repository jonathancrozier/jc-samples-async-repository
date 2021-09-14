CREATE DATABASE TodosAppDb
GO

USE [TodosAppDb]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Todos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Completed] [bit] NOT NULL,
 CONSTRAINT [PK_Todos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SET IDENTITY_INSERT [dbo].[Todos] ON 
INSERT [dbo].[Todos] ([Id], [UserId], [Title], [Completed]) VALUES (1, 2, N'Buy milk', 0)
INSERT [dbo].[Todos] ([Id], [UserId], [Title], [Completed]) VALUES (2, 2, N'Leave out the trash', 0)
INSERT [dbo].[Todos] ([Id], [UserId], [Title], [Completed]) VALUES (3, 2, N'Clean room', 0)
SET IDENTITY_INSERT [dbo].[Todos] OFF

SET IDENTITY_INSERT [dbo].[Users] ON 
INSERT [dbo].[Users] ([Id], [Username]) VALUES (1, N'Jonathan')
INSERT [dbo].[Users] ([Id], [Username]) VALUES (2, N'Rachel')
SET IDENTITY_INSERT [dbo].[Users] OFF

ALTER TABLE [dbo].[Todos] ADD  CONSTRAINT [DF_Todos_Completed]  DEFAULT ((0)) FOR [Completed]
GO
ALTER TABLE [dbo].[Todos]  WITH CHECK ADD  CONSTRAINT [FK_Todos_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Todos] CHECK CONSTRAINT [FK_Todos_Users]
GO