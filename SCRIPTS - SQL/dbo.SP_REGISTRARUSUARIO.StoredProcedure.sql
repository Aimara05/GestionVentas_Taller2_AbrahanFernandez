USE [DBInfiniteFenandezAbrahan]
GO
/****** Object:  StoredProcedure [dbo].[SP_REGISTRARUSUARIO]    Script Date: 6/10/2023 08:03:04 ******/
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
@clave varchar(50),
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
