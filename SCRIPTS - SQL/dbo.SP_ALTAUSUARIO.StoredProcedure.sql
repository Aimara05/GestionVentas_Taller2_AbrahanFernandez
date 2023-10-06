USE [DBInfiniteFenandezAbrahan]
GO
/****** Object:  StoredProcedure [dbo].[SP_ALTAUSUARIO]    Script Date: 6/10/2023 08:03:04 ******/
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
