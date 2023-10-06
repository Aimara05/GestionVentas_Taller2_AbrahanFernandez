USE [DBInfiniteFenandezAbrahan]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 6/10/2023 08:03:04 ******/
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
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (1, 1, N'40283879', N'Aimara', N'Fernandez', N'ayelenfer879@gmail.com', N'Aimara05', N'11223344', N'3794693040', N'murcia 234', 1, CAST(N'2023-09-17T00:54:39.550' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (5, 3, N'40389567', N'Yenhy', N'Morel', N'yeni222@gmail.com', N'Yenhy05', N'11223344', N'3795678909', N'Estados Unidos 234', 1, CAST(N'2023-09-20T20:39:41.980' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (11, 2, N'39367653', N'Ulises', N'Abrahan', N'ulisesabrahan858@gmail.com', N'Ulises05', N'11223344', N'3794183441', N'Los Cocos 5231', 1, CAST(N'2023-09-22T10:59:12.857' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (20, 3, N'40283877', N'Lucia', N'Gomezz', N'Lucia@gmail.com', N'lucia002', N'11223344', N'3795678765', N'Las violestas456', 0, CAST(N'2023-10-02T02:31:47.387' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (21, 3, N'18546545', N'Atilio', N'Abrahan', N'atilio@gmail.com', N'Atilio05', N'11223344', N'3794556688', N'Villa ocampo', 0, CAST(N'2023-10-02T23:22:55.830' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (22, 3, N'402839870', N'Luis', N'Gomez', N'luis@gmail.com', N'Luis05', N'11223344', N'3794050388', N'Quintana345', 1, CAST(N'2023-10-04T10:51:42.560' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (23, 3, N'123456', N'Juan', N'Carruthers', N'juan@gmail.com', N'Juan05', N'11223344', N'123456789', N'9 julio 1449', 1, CAST(N'2023-10-04T11:29:51.153' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (24, 2, N'40283765', N'Lola', N'Sanchez', N'lorensi@gmail.com', N'Lola05', N'11223344', N'1122334455', N'loreci 456', 0, CAST(N'2023-10-05T19:44:27.550' AS DateTime))
INSERT [dbo].[USUARIO] ([idUsuario], [IdRol], [documento], [nombre], [apellido], [correo], [usuario], [clave], [telefono], [direccion], [estado], [fechaCreacion]) VALUES (25, 3, N'564888888', N'sherlock', N'holmes', N'sherlock11@gmail.com', N'Sherlock', N'11223344', N'23123123', N'adddasdsadasd', 1, CAST(N'2023-10-06T07:42:19.377' AS DateTime))
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD FOREIGN KEY([IdRol])
REFERENCES [dbo].[ROL] ([idRol])
GO
