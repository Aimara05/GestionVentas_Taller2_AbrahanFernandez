USE [master]
GO
/****** Object:  Database [DBInfiniteFenandezAbrahan]    Script Date: 14/11/2023 11:55:43 ******/
CREATE DATABASE [DBInfiniteFenandezAbrahan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBInfiniteFenandezAbrahan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBInfiniteFenandezAbrahan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBInfiniteFenandezAbrahan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBInfiniteFenandezAbrahan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBInfiniteFenandezAbrahan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET  MULTI_USER 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET QUERY_STORE = OFF
GO
USE [DBInfiniteFenandezAbrahan]
GO
/****** Object:  UserDefinedTableType [dbo].[EDetalle_venta]    Script Date: 14/11/2023 11:55:43 ******/
CREATE TYPE [dbo].[EDetalle_venta] AS TABLE(
	[idProducto] [int] NULL,
	[precioVenta] [float] NULL,
	[cantidad] [int] NULL,
	[subtotal] [float] NULL
)
GO
/****** Object:  Table [dbo].[CATEGORIAS]    Script Date: 14/11/2023 11:55:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIAS](
	[idCateg] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[estadoCateg] [bit] NULL,
	[fechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCateg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[documentoCliente] [varchar](50) NULL,
	[nombreCliente] [varchar](50) NULL,
	[apellidoCliente] [varchar](50) NULL,
	[correo] [varchar](150) NULL,
	[telefono] [varchar](100) NULL,
	[estado] [bit] NULL,
	[fechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCAS]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCAS](
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
	[descripcionMarca] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[idCateg] [int] NULL,
	[idMarca] [int] NULL,
	[nombreProd] [varchar](100) NULL,
	[descripcionProd] [varchar](100) NULL,
	[talle] [varchar](50) NULL,
	[stock] [int] NULL,
	[estado] [bit] NULL,
	[fechaReg] [datetime] NULL,
	[precioUni] [float] NULL,
	[imagen] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROL](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[fechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOPAGO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOPAGO](
	[idTipoPago] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdRol] [int] NULL,
	[documento] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[correo] [varchar](150) NULL,
	[usuario] [varchar](150) NULL,
	[clave] [varchar](150) NULL,
	[telefono] [varchar](100) NULL,
	[direccion] [varchar](200) NULL,
	[estado] [bit] NULL,
	[fechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTADETALLE]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTADETALLE](
	[idVentaDetalle] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NULL,
	[idProducto] [int] NULL,
	[precioVenta] [float] NULL,
	[cantidad] [int] NULL,
	[subtotal] [float] NULL,
	[fechaReg] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idVentaDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTAS]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTAS](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idTipoPago] [int] NOT NULL,
	[codigoFactura] [varchar](50) NULL,
	[fechaReg] [datetime] NULL,
	[estadoVenta] [bit] NULL,
	[montoTotal] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATEGORIAS] ON 

INSERT [dbo].[CATEGORIAS] ([idCateg], [descripcion], [estadoCateg], [fechaCreacion]) VALUES (1, N'remeras y remerones', 0, CAST(N'2023-10-24T21:26:32.397' AS DateTime))
INSERT [dbo].[CATEGORIAS] ([idCateg], [descripcion], [estadoCateg], [fechaCreacion]) VALUES (2, N'jeanss', 1, CAST(N'2023-10-25T10:41:35.077' AS DateTime))
INSERT [dbo].[CATEGORIAS] ([idCateg], [descripcion], [estadoCateg], [fechaCreacion]) VALUES (3, N'gorras', 1, CAST(N'2023-10-26T18:07:05.623' AS DateTime))
INSERT [dbo].[CATEGORIAS] ([idCateg], [descripcion], [estadoCateg], [fechaCreacion]) VALUES (4, N'Short de jeans', 0, CAST(N'2023-10-26T18:25:00.600' AS DateTime))
INSERT [dbo].[CATEGORIAS] ([idCateg], [descripcion], [estadoCateg], [fechaCreacion]) VALUES (5, N'Vestidos Largos', 1, CAST(N'2023-10-29T04:29:44.840' AS DateTime))
SET IDENTITY_INSERT [dbo].[CATEGORIAS] OFF
GO
SET IDENTITY_INSERT [dbo].[CLIENTES] ON 

INSERT [dbo].[CLIENTES] ([idCliente], [documentoCliente], [nombreCliente], [apellidoCliente], [correo], [telefono], [estado], [fechaCreacion]) VALUES (1, N'40283878', N'Tomas', N'Lopez', N'tomas@gmail.com', N'3794885555', 0, CAST(N'2023-09-29T11:06:25.993' AS DateTime))
INSERT [dbo].[CLIENTES] ([idCliente], [documentoCliente], [nombreCliente], [apellidoCliente], [correo], [telefono], [estado], [fechaCreacion]) VALUES (2, N'40234543', N'Pedro', N'lopez', N'joseluis@gmail.com', N'15448899', 1, CAST(N'2023-10-11T10:00:36.657' AS DateTime))
INSERT [dbo].[CLIENTES] ([idCliente], [documentoCliente], [nombreCliente], [apellidoCliente], [correo], [telefono], [estado], [fechaCreacion]) VALUES (3, N'40283678', N'Lorena', N'Sanchez', N'Lorena@gmail.com', N'123123123123', 1, CAST(N'2023-10-11T10:01:58.577' AS DateTime))
INSERT [dbo].[CLIENTES] ([idCliente], [documentoCliente], [nombreCliente], [apellidoCliente], [correo], [telefono], [estado], [fechaCreacion]) VALUES (4, N'40283879', N'Aimara', N'Fernandez', N'Aimara05@gmail.com', N'3794567890', 1, CAST(N'2023-11-10T02:00:29.950' AS DateTime))
INSERT [dbo].[CLIENTES] ([idCliente], [documentoCliente], [nombreCliente], [apellidoCliente], [correo], [telefono], [estado], [fechaCreacion]) VALUES (5, N'35467890', N'Jimena', N'Fernandez', N'jimeFer@gmail.com', N'3897456789', 1, CAST(N'2023-11-13T12:14:54.987' AS DateTime))
SET IDENTITY_INSERT [dbo].[CLIENTES] OFF
GO
SET IDENTITY_INSERT [dbo].[MARCAS] ON 

INSERT [dbo].[MARCAS] ([idMarca], [descripcionMarca]) VALUES (1, N'Las Locas')
INSERT [dbo].[MARCAS] ([idMarca], [descripcionMarca]) VALUES (2, N'Vizano')
INSERT [dbo].[MARCAS] ([idMarca], [descripcionMarca]) VALUES (3, N'Aramia10')
SET IDENTITY_INSERT [dbo].[MARCAS] OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUCTOS] ON 

INSERT [dbo].[PRODUCTOS] ([idProducto], [idCateg], [idMarca], [nombreProd], [descripcionProd], [talle], [stock], [estado], [fechaReg], [precioUni], [imagen]) VALUES (1, 2, 3, N'Jeans Wit', N'Rigidos', N'36', 232, 1, NULL, 222, NULL)
INSERT [dbo].[PRODUCTOS] ([idProducto], [idCateg], [idMarca], [nombreProd], [descripcionProd], [talle], [stock], [estado], [fechaReg], [precioUni], [imagen]) VALUES (2, 2, 1, N'Jeans Chupin', N'Talles reales, color blanco', N'23', 4, 0, NULL, 12000, NULL)
INSERT [dbo].[PRODUCTOS] ([idProducto], [idCateg], [idMarca], [nombreProd], [descripcionProd], [talle], [stock], [estado], [fechaReg], [precioUni], [imagen]) VALUES (3, 1, 1, N'Remeron Luk', N'de algodon  ', N'4,6,8', 10, 0, NULL, 1300, NULL)
INSERT [dbo].[PRODUCTOS] ([idProducto], [idCateg], [idMarca], [nombreProd], [descripcionProd], [talle], [stock], [estado], [fechaReg], [precioUni], [imagen]) VALUES (4, 2, 1, N'Short', N'mom', N'48', 0, 1, NULL, 12000, NULL)
INSERT [dbo].[PRODUCTOS] ([idProducto], [idCateg], [idMarca], [nombreProd], [descripcionProd], [talle], [stock], [estado], [fechaReg], [precioUni], [imagen]) VALUES (5, 2, 1, N'Jeans Mom', N'Rigidos, color azul', N'48,89,90', 0, 1, NULL, 2000, NULL)
INSERT [dbo].[PRODUCTOS] ([idProducto], [idCateg], [idMarca], [nombreProd], [descripcionProd], [talle], [stock], [estado], [fechaReg], [precioUni], [imagen]) VALUES (6, 1, 1, N'Remeron', N'oversige', N'6', 54, 1, NULL, 3000, NULL)
INSERT [dbo].[PRODUCTOS] ([idProducto], [idCateg], [idMarca], [nombreProd], [descripcionProd], [talle], [stock], [estado], [fechaReg], [precioUni], [imagen]) VALUES (7, 2, 1, N'Shorts Jeans', N'Rigidos', N'48', 191, 1, NULL, 30000, NULL)
SET IDENTITY_INSERT [dbo].[PRODUCTOS] OFF
GO
SET IDENTITY_INSERT [dbo].[ROL] ON 

INSERT [dbo].[ROL] ([idRol], [descripcion], [fechaCreacion]) VALUES (1, N'ADMINISTRADOR', CAST(N'2023-09-17T00:14:13.303' AS DateTime))
INSERT [dbo].[ROL] ([idRol], [descripcion], [fechaCreacion]) VALUES (2, N'SuperAdministrador', CAST(N'2023-09-20T20:22:44.477' AS DateTime))
INSERT [dbo].[ROL] ([idRol], [descripcion], [fechaCreacion]) VALUES (3, N'Vendedor', CAST(N'2023-09-20T20:23:07.110' AS DateTime))
SET IDENTITY_INSERT [dbo].[ROL] OFF
GO
SET IDENTITY_INSERT [dbo].[TIPOPAGO] ON 

INSERT [dbo].[TIPOPAGO] ([idTipoPago], [descripcion]) VALUES (1, N'Efectivo')
INSERT [dbo].[TIPOPAGO] ([idTipoPago], [descripcion]) VALUES (2, N'Tarjeta')
INSERT [dbo].[TIPOPAGO] ([idTipoPago], [descripcion]) VALUES (3, N'Mercado Pago')
SET IDENTITY_INSERT [dbo].[TIPOPAGO] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (26, 2, N'11111111111', N'super', N'admin', N'superadmin@gmail.com', N'Super05', N'$2a$11$/8HV4PMA9eFjkV1966KTzux2XSdW0paCF.ZKFJV6Yaxm4phEQvbmi', N'1231231231', N'aadasd123', 1, CAST(N'2023-11-10T09:41:03.667' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (27, 3, N'40283879', N'Hernan', N'Lopez', N'herman@gmail.com', N'Hernan05', N'$2a$11$Hfg6m1r7YzWoE3stngK9vO0BOQDyP/HzwsRuEGay4Xg', N'3798567890', N'Grecia 345', 1, CAST(N'2023-11-10T09:58:45.580' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (28, 2, N'121212112125566', N'luciano', N'aromi', N'luciano@gmail.com', N'Lucian05', N'$2a$11$d4qNlue.isPISSPK0COMi.c7K.9bLg.8hTbq4gNMVlH3l7XdNC812', N'51655469', N'avarmenia', 1, CAST(N'2023-11-10T10:02:09.000' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (29, 1, N'6516565564', N'Damian', N'Ross', N'admin@gmail.com', N'Admin05', N'$2a$11$Iz7kv6gO5EfmkQsmzcrKxuoqrlU2JJjmvrgo2MR0yjyAI/N/QoWEu', N'123123', N'q123123', 0, CAST(N'2023-11-10T10:05:47.860' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (30, 3, N'12654656521', N'Vendedor', N'dos', N'vendedor@mail.com', N'Vend05', N'$2a$11$1Eo7miMw.LVKVbEIxX6aeug/2mu87cyJRhLTnzqv1gq6LakYodEOS', N'123123456', N'31543534', 1, CAST(N'2023-11-10T10:09:12.480' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (31, 1, N'40283878', N'Aimara', N'Fernandez', N'Aima@gmail.com', N'Aimara05', N'$2a$11$WJCtUZltkSwBbO24EPpVUu8Gg.WGBcGHFOUMFARBNQ7mvw7.KrA6m', N'3794693034', N'Grecia 234', 1, CAST(N'2023-11-10T11:24:33.723' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (32, 3, N'39367653', N'Ulises', N'Abrahan', N'ulises12@gmail.com', N'Ulises05', N'$2a$11$n4F295k0NsDjaF/WGhOWpuZTQgyU9pLHVX6vEI0iBzO3CtV/oHwOW', N'379484885', N'juan de aray', 1, CAST(N'2023-11-14T10:21:34.027' AS DateTime))
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO
SET IDENTITY_INSERT [dbo].[VENTADETALLE] ON 

INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (8, 5, 2, 123, 1, 123, CAST(N'2023-11-10T10:10:45.400' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (9, 5, 1, 222, 1, 222, CAST(N'2023-11-10T10:10:45.400' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (10, 6, 2, 200, 3, 123, CAST(N'2023-11-12T11:12:33.483' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (11, 6, 2, 123, 2, 246, CAST(N'2023-11-12T11:12:33.483' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (12, 7, 2, 123, 1, 123, CAST(N'2023-11-12T11:47:29.983' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (13, 7, 1, 222, 1, 222, CAST(N'2023-11-12T11:47:29.983' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (14, 8, 1, 222, 1, 222, CAST(N'2023-11-12T16:16:27.347' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (15, 9, 2, 123, 1, 123, CAST(N'2023-11-12T16:34:00.043' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (16, 9, 1, 222, 1, 222, CAST(N'2023-11-12T16:34:00.043' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (17, 10, 5, 2000, 1, 2000, CAST(N'2023-11-12T22:24:09.963' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (18, 11, 5, 2000, 2, 4000, CAST(N'2023-11-13T18:47:01.503' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (19, 12, 5, 2000, 3, 2000, CAST(N'2023-11-13T19:42:52.527' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (20, 13, 6, 3000, 1, 3000, CAST(N'2023-11-14T00:55:39.653' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (21, 14, 7, 30000, 1, 30000, CAST(N'2023-11-14T08:25:20.837' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (22, 15, 1, 222, 1, 222, CAST(N'2023-11-14T08:50:40.580' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (23, 16, 6, 3000, 1, 3000, CAST(N'2023-11-14T09:08:04.590' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (24, 17, 6, 3000, 1, 3000, CAST(N'2023-11-14T10:11:38.973' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (25, 18, 5, 2000, 1, 2000, CAST(N'2023-11-14T10:15:33.143' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (26, 19, 7, 30000, 1, 30000, CAST(N'2023-11-14T10:27:14.563' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (27, 20, 6, 3000, 2, 3000, CAST(N'2023-11-14T10:37:11.123' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (28, 21, 5, 2000, 2, 4000, CAST(N'2023-11-14T10:52:27.243' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (29, 22, 1, 222, 1, 222, CAST(N'2023-11-14T10:53:41.107' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (30, 22, 7, 30000, 2, 60000, CAST(N'2023-11-14T10:53:41.107' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (31, 22, 6, 3000, 1, 3000, CAST(N'2023-11-14T10:53:41.107' AS DateTime))
INSERT [dbo].[VENTADETALLE] ([idVentaDetalle], [idVenta], [idProducto], [precioVenta], [cantidad], [subtotal], [fechaReg]) VALUES (32, 23, 6, 3000, 1, 3000, CAST(N'2023-11-14T11:04:00.613' AS DateTime))
SET IDENTITY_INSERT [dbo].[VENTADETALLE] OFF
GO
SET IDENTITY_INSERT [dbo].[VENTAS] ON 

INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (5, 30, 2, 2, N'00005', CAST(N'2023-11-10T10:10:45.400' AS DateTime), 1, CAST(345 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (6, 30, 1, 1, N'00002', CAST(N'2023-11-12T11:12:33.480' AS DateTime), 1, CAST(369 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (7, 30, 4, 1, N'00003', CAST(N'2023-11-12T11:47:29.983' AS DateTime), 1, CAST(345 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (8, 30, 2, 1, N'00004', CAST(N'2023-11-12T16:16:27.347' AS DateTime), 1, CAST(222 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (9, 30, 1, 1, N'00005', CAST(N'2023-11-12T16:34:00.043' AS DateTime), 1, CAST(345 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (10, 30, 1, 1, N'00006', CAST(N'2023-11-12T22:24:09.960' AS DateTime), 1, CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (11, 30, 4, 1, N'00007', CAST(N'2023-11-13T18:47:01.500' AS DateTime), 1, CAST(4000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (12, 30, 3, 1, N'00008', CAST(N'2023-11-13T19:42:52.527' AS DateTime), 1, CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (13, 30, 4, 1, N'00009', CAST(N'2023-11-14T00:55:39.647' AS DateTime), 1, CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (14, 30, 3, 1, N'00010', CAST(N'2023-11-14T08:25:20.837' AS DateTime), 1, CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (15, 30, 2, 1, N'00011', CAST(N'2023-11-14T08:50:40.580' AS DateTime), 1, CAST(222 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (16, 30, 4, 1, N'00012', CAST(N'2023-11-14T09:08:04.590' AS DateTime), 1, CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (17, 30, 2, 1, N'00013', CAST(N'2023-11-14T10:11:38.967' AS DateTime), 1, CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (18, 30, 4, 1, N'00014', CAST(N'2023-11-14T10:15:33.143' AS DateTime), 1, CAST(2000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (19, 32, 2, 1, N'00015', CAST(N'2023-11-14T10:27:14.560' AS DateTime), 1, CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (20, 32, 4, 1, N'00016', CAST(N'2023-11-14T10:37:11.123' AS DateTime), 1, CAST(3000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (21, 32, 2, 1, N'00017', CAST(N'2023-11-14T10:52:27.243' AS DateTime), 1, CAST(4000 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (22, 32, 2, 1, N'00018', CAST(N'2023-11-14T10:53:41.107' AS DateTime), 1, CAST(63222 AS Decimal(18, 0)))
INSERT [dbo].[VENTAS] ([idVenta], [idUsuario], [idCliente], [idTipoPago], [codigoFactura], [fechaReg], [estadoVenta], [montoTotal]) VALUES (23, 30, 2, 1, N'00019', CAST(N'2023-11-14T11:04:00.613' AS DateTime), 1, CAST(3000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[VENTAS] OFF
GO
ALTER TABLE [dbo].[CATEGORIAS] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[CLIENTES] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[ROL] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[VENTADETALLE] ADD  CONSTRAINT [DF_VENTADETALLE_fechaReg]  DEFAULT (getdate()) FOR [fechaReg]
GO
ALTER TABLE [dbo].[VENTAS] ADD  CONSTRAINT [DF_VENTAS_fechaReg]  DEFAULT (getdate()) FOR [fechaReg]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD FOREIGN KEY([idCateg])
REFERENCES [dbo].[CATEGORIAS] ([idCateg])
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD FOREIGN KEY([idMarca])
REFERENCES [dbo].[MARCAS] ([idMarca])
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([idRol])
GO
ALTER TABLE [dbo].[VENTADETALLE]  WITH CHECK ADD FOREIGN KEY([idProducto])
REFERENCES [dbo].[PRODUCTOS] ([idProducto])
GO
ALTER TABLE [dbo].[VENTADETALLE]  WITH CHECK ADD  CONSTRAINT [FK_VENTADETALLE_VENTAS] FOREIGN KEY([idVenta])
REFERENCES [dbo].[VENTAS] ([idVenta])
GO
ALTER TABLE [dbo].[VENTADETALLE] CHECK CONSTRAINT [FK_VENTADETALLE_VENTAS]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([idCliente])
REFERENCES [dbo].[CLIENTES] ([idCliente])
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([idTipoPago])
REFERENCES [dbo].[TIPOPAGO] ([idTipoPago])
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD FOREIGN KEY([idUsuario])
REFERENCES [dbo].[USUARIO] ([idUsuario])
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTACATEGORIA]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTACATEGORIA](
    @idCateg int,
    @respuesta bit output,
    @mensaje varchar(500) output
)
as
begin
    set @respuesta = 0
    set @mensaje = ''

    if exists(select * from CATEGORIAS where idCateg = @idCateg)
    begin
        UPDATE CATEGORIAS SET estadoCateg = 1 WHERE idCateg = @idCateg;
        set @respuesta = 1
    end
    else
        set @mensaje = 'La categoría no existe en la base de datos'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTACLIENTE]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTACLIENTE](
@idCliente int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
    set @respuesta = 0
    set @mensaje = ''



    if exists(select * from CLIENTES where @idCliente = @idCliente)
    begin
        UPDATE CLIENTES SET estado = 1 WHERE idCliente = @idCliente;

        set @respuesta = 1

    end
    else
        set @mensaje = 'El cliente no existe en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTAPRODUCTO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ALTAPRODUCTO](
@idProducto int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
    set @respuesta = 0
    set @mensaje = ''



    if exists(select * from PRODUCTOS where idProducto = @idProducto)
    begin
        UPDATE PRODUCTOS SET estado = 1 WHERE idProducto = @idProducto;

        set @respuesta = 1

    end
    else
        set @mensaje = 'El usuario no existe en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTAUSUARIO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[SP_ALTAUSUARIO](
@idUsuario int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
    set @respuesta = 0
    set @mensaje = ''



    if exists(select * from USUARIO where idUsuario = @idUsuario)
    begin
        UPDATE USUARIO SET estado = 1 WHERE idUsuario = @idUsuario;

        set @respuesta = 1

    end
    else
        set @mensaje = 'El usuario no existe en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARCATEGORIA]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARCATEGORIA](
@idCateg int,
@descripcion varchar(100),
@estadoCateg bit,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists(select * from CATEGORIAS where descripcion = @descripcion and @idCateg != @idCateg)
	begin
		update CATEGORIAS set
		descripcion = @descripcion,
		estadoCateg = @estadoCateg
		where idCateg = @idCateg

		set @respuesta = 1

	end
	else
		set @mensaje = 'No se puede repetir la misma categoria'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARCLIENTE]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_EDITARCLIENTE](
@idCliente int,

@documentoCliente varchar(50),
@nombreCliente varchar(50),
@apellidoCliente varchar(50),
@correo varchar(50),
@telefono varchar(50),
@estado bit,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists(select * from CLIENTES where documentoCliente = @documentoCliente and idCliente != @idCliente)
	begin
		update CLIENTES set
		documentoCliente = @documentoCliente,
		nombreCliente = @nombreCliente,
		apellidoCliente = @apellidoCliente,
		correo = @correo,
		telefono = @telefono,
		estado = @estado 
		where idCliente = @idCliente

		set @respuesta = 1

	end
	else
		set @mensaje = 'No se puede repetir el documento para más de un cliente'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARPRODUCTO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARPRODUCTO](
@idProducto int,
@idCateg int,
@idMarca int,
@nombreProd varchar(100),
@descripcionProd varchar(100),
@talle varchar(50),
@stock int,
@estado bit,
@precioUni float,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists(select * from PRODUCTOS where nombreProd = @nombreProd and idProducto != @idProducto)
	begin
		update PRODUCTOS set
		idCateg = @idCateg,
		idMarca = @idMarca,
		nombreProd = @nombreProd,
		descripcionProd = @descripcionProd,
		talle = @talle,
		stock = @stock,
		estado = @estado,
		precioUni = @precioUni


		where idProducto = @idProducto

		set @respuesta = 1

	end
	else
		set @mensaje = 'No se puede repetir el mismo producto'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARUSUARIO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EDITARUSUARIO](
@idUsuario int,
@idRol int,
@documento varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@correo varchar(50),
@usuario varchar(50),

@telefono varchar(50),
@direccion varchar(50),
@estado bit,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	if not exists(select * from USUARIO where documento = @documento and idUsuario != @idUsuario)
	begin
		update USUARIO set
		IdRol = @idRol,
		documento = @documento,
		nombre = @nombre,
		apellido = @apellido,
		correo = @correo,
		usuario = @usuario,
		
		telefono = @telefono,
		direccion = @direccion,
		estado = @estado 
		where idUsuario = @idUsuario

		set @respuesta = 1

	end
	else
		set @mensaje = 'No se puede repetir el documento para más de un usuario'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARCATEGORIA]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARCATEGORIA](
@idCateg int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
    set @respuesta = 0
    set @mensaje = ''



    if exists(select * from CATEGORIAS where idCateg = @idCateg)
    begin
        UPDATE CATEGORIAS SET estadoCateg = 0 WHERE idCateg = @idCateg;

        set @respuesta = 1

    end
    else
        set @mensaje = 'La categoria no existe en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARCLIENTE]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARCLIENTE](
@idCliente int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
    set @respuesta = 0
    set @mensaje = ''



    if exists(select * from CLIENTES where idCliente = @idCliente)
    begin
        UPDATE CLIENTES SET estado = 0 WHERE idCliente = @idCliente;

        set @respuesta = 1

    end
    else
        set @mensaje = 'El cliente no existe en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARPRODUCTO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARPRODUCTO](
@idProducto int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
	set @respuesta = 0
	set @mensaje = ''

	

	if exists(select * from PRODUCTOS where idProducto = @idProducto)
	begin
		UPDATE PRODUCTOS SET estado = 0 WHERE idProducto = @idProducto;

        set @respuesta = 1


	end
	else
		set @mensaje = 'El producto no existe en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARUSUARIO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ELIMINARUSUARIO](
@idUsuario int,
@respuesta bit output,
@mensaje varchar(500) output
)
as
begin
    set @respuesta = 0
    set @mensaje = ''



    if exists(select * from USUARIO where idUsuario = @idUsuario)
    begin
        UPDATE USUARIO SET estado = 0 WHERE idUsuario = @idUsuario;

        set @respuesta = 1

    end
    else
        set @mensaje = 'El usuario no existe en la base de datos'

end
GO
/****** Object:  StoredProcedure [dbo].[sp_montosvendedor]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Montos totales generados por cada vendedor en relación a la venta*/
CREATE PROCEDURE [dbo].[sp_montosvendedor]
    @FechaInicio VARCHAR(10),
    @FechaFin VARCHAR(10)
AS
BEGIN
    SET DATEFORMAT dmy;

    SELECT
        U.nombre + ' ' + U.apellido AS Vendedor,
        SUM(V.montoTotal) AS MontoTotalGenerado
    FROM
        VENTAS V
    INNER JOIN
        USUARIO U ON V.idUsuario = U.idUsuario
    WHERE
        CONVERT(DATE, V.fechaReg) BETWEEN @FechaInicio AND @FechaFin
    GROUP BY
        U.nombre, U.apellido
    ORDER BY
        MontoTotalGenerado DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_prodmasvendidos]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Productos más vendidos en relación a la fecha: */

CREATE PROCEDURE [dbo].[sp_prodmasvendidos]
    @FechaInicio VARCHAR(10),
    @FechaFin VARCHAR(10)
AS
BEGIN
    SET DATEFORMAT dmy;

    SELECT
        P.nombreProd,
        SUM(VD.cantidad) AS CantidadVendida
    FROM
        VENTADETALLE VD
    INNER JOIN
        PRODUCTOS P ON VD.idProducto = P.idProducto
    INNER JOIN
        VENTAS V ON VD.idVenta = V.idVenta
    WHERE
        CONVERT(DATE, V.fechaReg) BETWEEN @FechaInicio AND @FechaFin
    GROUP BY
        P.nombreProd
    ORDER BY
        CantidadVendida DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_prodmontos]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Montos totales recaudados por cada producto: */

CREATE PROC [dbo].[sp_prodmontos]
    @fechainicio varchar(10),
    @fechafin varchar(10)

AS
BEGIN
    SET DATEFORMAT dmy;

    SELECT
        P.nombreProd,
        SUM(VD.subtotal) AS MontoTotalRecaudado
    FROM
        VENTADETALLE VD
    INNER JOIN
        PRODUCTOS P ON VD.idProducto = P.idProducto
    INNER JOIN
        VENTAS V ON VD.idVenta = V.idVenta
    WHERE
        CONVERT(date, V.fechaReg) BETWEEN CONVERT(date, @fechainicio) AND CONVERT(date, @fechafin)
    GROUP BY
        P.nombreProd
    ORDER BY
        MontoTotalRecaudado DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARCATEGORIA]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARCATEGORIA](
@descripcion varchar(100),
@estadoCateg bit,
@idCategoriaResultado int output,
@mensaje varchar(500) output
)
as
begin
	set @idCategoriaResultado = 0
	set @mensaje = ''

	if not exists(select * from CATEGORIAS where descripcion = @descripcion)
	begin
		insert into CATEGORIAS(descripcion,estadoCateg) values 
		(@descripcion,@estadoCateg)

		set @idCategoriaResultado = SCOPE_IDENTITY()

	end
	else
		set @mensaje = 'No se puede repetir la misma categoria'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARCLIENTE]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARCLIENTE](
@documentoCliente varchar(50),
@nombreCliente varchar(50),
@apellidoCliente varchar(50),
@correo varchar(150),
@telefono varchar(100),
@estado bit,
@idClienteResultado int output,
@mensaje varchar(500) output
)
as
begin
	set @idClienteResultado = 0
	set @mensaje = ''

	if not exists(select * from CLIENTES where documentoCliente = @documentoCliente)
	begin
		insert into CLIENTES(documentoCliente,nombreCliente,apellidoCliente,correo,telefono,estado) values 
		(@documentoCliente,@nombreCliente,@apellidoCliente,@correo,@telefono,@estado)

		set @idClienteResultado = SCOPE_IDENTITY()

	end
	else
		set @mensaje = 'No se puede repetir el documento para más de un cliente'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARPRODUCTO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARPRODUCTO](
@idCateg int,
@idMarca int,
@nombreProd varchar(100),
@descripcionProd varchar(100),
@talle varchar(50),
@stock int,
@estado bit,
@precioUni float,

@idProductoResultado int output,
@mensaje varchar(500) output
)
as
begin
	set @idProductoResultado = 0
	set @mensaje = ''

	if not exists(select * from PRODUCTOS where nombreProd = @nombreProd)
	begin
		insert into PRODUCTOS(idCateg, idMarca,nombreProd,descripcionProd,talle,stock,estado,precioUni) values 
		(@idCateg,@idMarca,@nombreProd,@descripcionProd,@talle,@stock,@estado,@precioUni)

		set @idProductoResultado = SCOPE_IDENTITY()

	end
	else
		set @mensaje = 'No se puede repetir el mismo producto'

end
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARUSUARIO]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_REGISTRARUSUARIO](
@idRol int,
@documento varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@correo varchar(50),
@usuario varchar(50),
@clave varchar(150),
@telefono varchar(50),
@direccion varchar(50),
@estado bit,
@idUsuarioResultado int output,
@mensaje varchar(500) output
)
as
begin
	set @idUsuarioResultado = 0
	set @mensaje = ''

	IF NOT EXISTS (SELECT * FROM USUARIO WHERE documento = @documento)
    BEGIN
        IF NOT EXISTS (SELECT * FROM USUARIO WHERE correo = @correo)
        BEGIN
            IF NOT EXISTS (SELECT * FROM USUARIO WHERE usuario = @usuario)
            BEGIN
                INSERT INTO USUARIO (IdRol, documento, nombre, apellido, correo, usuario, clave, telefono, direccion, estado)
                VALUES (@idRol, @documento, @nombre, @apellido, @correo, @usuario, @clave, @telefono, @direccion, @estado)

                SET @idUsuarioResultado = SCOPE_IDENTITY()
            END
            ELSE
            BEGIN
                SET @mensaje = 'No se puede repetir el nombre de usuario para más de un usuario'
            END
        END
        ELSE
        BEGIN
            SET @mensaje = 'No se puede repetir el correo electrónico para más de un usuario'
        END
    END
    ELSE
    BEGIN
        SET @mensaje = 'No se puede repetir el documento para más de un usuario'
    END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ReporteVentas]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ReporteVentas](
@fechainicio varchar(10),
@fechafin varchar(10)
)
as
begin
SET DATEFORMAT dmy;
select
convert(char(10),v.fechaReg,103)[FechaRegistro], v.codigoFactura, v.montoTotal, tp.descripcion[TipoPago],
u.nombre[UsuarioNombre], u.apellido[UsuarioApellido], u.documento[DniUsuario],
c.nombreCliente,c.apellidoCliente, c.documentoCliente,
p.idProducto, p.nombreProd[NombreProducto], ca.descripcion[Categoria],ma.descripcionMarca[Marca],
dv.precioVenta, dv.cantidad, dv.subtotal
from VENTAS v
inner join USUARIO u on u.idUsuario = v.idUsuario
inner join TIPOPAGO tp on tp.idTipoPago = v.idTipoPago
inner join CLIENTES c on c.idCliente = v.idCliente
inner join VENTADETALLE dv on dv.idVenta = v.idVenta
inner join PRODUCTOS p on p.idProducto = dv.idProducto
inner join CATEGORIAS ca on ca.idCateg = p.idCateg
inner join MARCAS ma on ma.idMarca = p.idMarca
where CONVERT(date, v.fechaReg) between @fechainicio and @fechafin
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ventascantidad]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* Vendedores que realizaron más ventas (cantidad de venta por vendedor */
CREATE PROCEDURE [dbo].[sp_ventascantidad]
    @FechaInicio VARCHAR(10),
    @FechaFin VARCHAR(10)
AS
BEGIN
    SET DATEFORMAT dmy;

    SELECT
        U.nombre + ' ' + U.apellido AS Vendedor,
        COUNT(V.idVenta) AS CantidadVentas
    FROM
        VENTAS V
    INNER JOIN
        USUARIO U ON V.idUsuario = U.idUsuario
    WHERE
        CONVERT(DATE, V.fechaReg) BETWEEN @FechaInicio AND @FechaFin
    GROUP BY
        U.nombre, U.apellido
    ORDER BY
        CantidadVentas DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_RegistrarVenta]    Script Date: 14/11/2023 11:55:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_RegistrarVenta](
@idUsuario int,
@idCliente int,
@idTipoPago int,
@codigoFactura varchar(50),


@estadoVenta bit,
@montoTotal decimal,
@DetalleVenta [EDetalle_venta] READONLY,
@Resultado bit output,
@Mensaje varchar(500) output
)
as
begin

	begin try

		declare @idventa int=0
		set @Resultado = 1
		set @Mensaje = ''

		begin transaction registro

		insert into VENTAS(idUsuario, idCliente, idTipoPago, codigoFactura, estadoVenta, montoTotal)
		values(@idUsuario,@idCliente,@idTipoPago,@codigoFactura, @estadoVenta,@montoTotal)

		set @idventa = SCOPE_IDENTITY()

		insert into VENTADETALLE(idVenta, idProducto, precioVenta, cantidad, subtotal)
		select @idventa,idProducto,precioVenta,cantidad,subtotal from @DetalleVenta

		commit transaction registro

	end try
	begin catch
		set @Resultado = 0
		set @Mensaje = ERROR_MESSAGE()
		rollback transaction registro
	end catch

end
GO
USE [master]
GO
ALTER DATABASE [DBInfiniteFenandezAbrahan] SET  READ_WRITE 
GO
