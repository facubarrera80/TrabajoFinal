USE [DBPanaderia]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 16/11/2023 17:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Nombre] [varchar](50) NULL,
	[Usuario] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Usuarios] ([Nombre], [Usuario], [Contraseña]) VALUES (N'Joaquin Alvarez', N'JAlvarez', N'1234')
INSERT [dbo].[Usuarios] ([Nombre], [Usuario], [Contraseña]) VALUES (N'Mariano Ayala', N'MAyala', N'1234')
INSERT [dbo].[Usuarios] ([Nombre], [Usuario], [Contraseña]) VALUES (N'Axel Sandoval', N'ASandoval', N'1234')
INSERT [dbo].[Usuarios] ([Nombre], [Usuario], [Contraseña]) VALUES (N'Bruno Aguirre', N'BAguirre', N'1234')
INSERT [dbo].[Usuarios] ([Nombre], [Usuario], [Contraseña]) VALUES (N'Ruben Hernandez', N'RHernandez', N'1234')
INSERT [dbo].[Usuarios] ([Nombre], [Usuario], [Contraseña]) VALUES (N'Santiago Bazan', N'SBazan', N'1234')
GO
