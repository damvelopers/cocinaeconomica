USE [BancoAlimentos]
GO

drop table Producto
drop table Alimento
drop table Almacen
drop table Imagen
drop table Salida
drop table Familia

/****** Object:  Table [dbo].[Alimento]    Script Date: 26/10/2016 20:06:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alimento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Imagen] [int] NULL,
	[Familia] [int] NULL,
	[Descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_Alimento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Almacen]    Script Date: 26/10/2016 20:06:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Almacen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](200) NULL,
 CONSTRAINT [PK_Almacen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 26/10/2016 20:06:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Imagen]    Script Date: 26/10/2016 20:06:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Imagen](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Imagen] [varbinary](max) NULL,
 CONSTRAINT [PK_Imagen] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 26/10/2016 20:06:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Alimento] [int] NOT NULL,
	[FechaEntrada] [date] NULL,
	[FechaCaducidad] [date] NOT NULL,
	[FechaConsPref] [date] NULL,
	[Proveedor] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NOT NULL,
	[Almacen] [int] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salida]    Script Date: 26/10/2016 20:06:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaSalida] [date] NOT NULL,
	[Alimento] [int] NOT NULL,
 CONSTRAINT [PK_Salida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Alimento]  WITH CHECK ADD  CONSTRAINT [FK_Alimento_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id])
GO
ALTER TABLE [dbo].[Alimento] CHECK CONSTRAINT [FK_Alimento_Familia]
GO
ALTER TABLE [dbo].[Alimento]  WITH CHECK ADD  CONSTRAINT [FK_Alimento_Imagen] FOREIGN KEY([Imagen])
REFERENCES [dbo].[Imagen] ([Id])
GO
ALTER TABLE [dbo].[Alimento] CHECK CONSTRAINT [FK_Alimento_Imagen]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Alimento] FOREIGN KEY([Alimento])
REFERENCES [dbo].[Alimento] ([Id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Alimento]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Almacen] FOREIGN KEY([Almacen])
REFERENCES [dbo].[Almacen] ([Id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Almacen]
GO
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD  CONSTRAINT [FK_Salida_Alimento] FOREIGN KEY([Alimento])
REFERENCES [dbo].[Alimento] ([Id])
GO
ALTER TABLE [dbo].[Salida] CHECK CONSTRAINT [FK_Salida_Alimento]
GO
