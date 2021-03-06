USE [BancoAlimentos]
GO
/****** Object:  User [cocina]    Script Date: 11/02/2017 14:56:06 ******/
CREATE USER [cocina] FOR LOGIN [cocina] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [cocina]
GO
/****** Object:  Table [dbo].[Alimento]    Script Date: 11/02/2017 14:56:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alimento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
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
/****** Object:  Table [dbo].[Almacen]    Script Date: 11/02/2017 14:56:07 ******/
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
/****** Object:  Table [dbo].[Entidad]    Script Date: 11/02/2017 14:56:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entidad](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](200) NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [varchar](11) NULL,
	[Descripcion] [varchar](50) NULL,
	[Web] [varchar](30) NULL,
	[DNI] [varchar](10) NULL,
	[CIF] [varchar](50) NULL,
 CONSTRAINT [PK_Entidad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 11/02/2017 14:56:07 ******/
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
/****** Object:  Table [dbo].[Imagen]    Script Date: 11/02/2017 14:56:07 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 11/02/2017 14:56:07 ******/
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
	[Entidad] [int] NULL,
	[Cantidad] [decimal](18, 2) NULL CONSTRAINT [DF_Producto_Cantidad]  DEFAULT ((0)),
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salida]    Script Date: 11/02/2017 14:56:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaSalida] [date] NOT NULL,
	[Alimento] [int] NOT NULL,
	[Cliente] [int] NULL,
	[Cantidad] [float] NULL,
 CONSTRAINT [PK_Salida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Alimento]  WITH CHECK ADD  CONSTRAINT [FK_Alimento_Familia] FOREIGN KEY([Familia])
REFERENCES [dbo].[Familia] ([Id])
ON DELETE SET NULL
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
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Alimento]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Almacen] FOREIGN KEY([Almacen])
REFERENCES [dbo].[Almacen] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Almacen]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Entidad] FOREIGN KEY([Entidad])
REFERENCES [dbo].[Entidad] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Entidad]
GO
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD  CONSTRAINT [FK_Salida_Alimento] FOREIGN KEY([Alimento])
REFERENCES [dbo].[Alimento] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Salida] CHECK CONSTRAINT [FK_Salida_Alimento]
GO
ALTER TABLE [dbo].[Salida]  WITH CHECK ADD  CONSTRAINT [FK_Salida_Cliente] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Entidad] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Salida] CHECK CONSTRAINT [FK_Salida_Cliente]
GO
