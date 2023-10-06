USE [DBInfiniteFenandezAbrahan]
GO
/****** Object:  Table [dbo].[ROL]    Script Date: 6/10/2023 08:03:04 ******/
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
SET IDENTITY_INSERT [dbo].[ROL] ON 

INSERT [dbo].[ROL] ([idRol], [descripcion], [fechaCreacion]) VALUES (1, N'ADMINISTRADOR', CAST(N'2023-09-17T00:14:13.303' AS DateTime))
INSERT [dbo].[ROL] ([idRol], [descripcion], [fechaCreacion]) VALUES (2, N'SuperAdministrador', CAST(N'2023-09-20T20:22:44.477' AS DateTime))
INSERT [dbo].[ROL] ([idRol], [descripcion], [fechaCreacion]) VALUES (3, N'Vendedor', CAST(N'2023-09-20T20:23:07.110' AS DateTime))
SET IDENTITY_INSERT [dbo].[ROL] OFF
GO
ALTER TABLE [dbo].[ROL] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
