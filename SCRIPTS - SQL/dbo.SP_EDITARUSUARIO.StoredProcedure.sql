USE [DBInfiniteFenandezAbrahan]
GO
/****** Object:  StoredProcedure [dbo].[SP_EDITARUSUARIO]    Script Date: 6/10/2023 08:03:04 ******/
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
@clave varchar(50),
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
		clave = @clave,
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
