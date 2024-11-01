USE [DBPanaderia]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 16/11/2023 17:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Codigo] [varchar](50) NULL,
	[Producto] [varchar](50) NULL,
	[Precio] [decimal](18, 0) NULL,
	[Stock] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Productos] ([Codigo], [Producto], [Precio], [Stock]) VALUES (N'001', N'Tortillas', CAST(50 AS Decimal(18, 0)), 1000)
INSERT [dbo].[Productos] ([Codigo], [Producto], [Precio], [Stock]) VALUES (N'002', N'Facturas', CAST(180 AS Decimal(18, 0)), 250)
INSERT [dbo].[Productos] ([Codigo], [Producto], [Precio], [Stock]) VALUES (N'003', N'Pan Francés', CAST(800 AS Decimal(18, 0)), 10)
INSERT [dbo].[Productos] ([Codigo], [Producto], [Precio], [Stock]) VALUES (N'004', N'Sacramentos', CAST(200 AS Decimal(18, 0)), 150)
INSERT [dbo].[Productos] ([Codigo], [Producto], [Precio], [Stock]) VALUES (N'005', N'Tortilla gruesa', CAST(70 AS Decimal(18, 0)), 800)
GO
