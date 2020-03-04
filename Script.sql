create table Video(
idVideo int primary key,
titulo varchar(100),
repro int,
url varchar(100)
)

create procedure sp_video_insertar
@idVideo int,
@titulo varchar(100),
@repro int,
@url varchar(100)
AS
BEGIN 
	insert into Video Values(@idVideo,@titulo,@repro,@url)

END

EXEC sp_video_insertar 1,'video 1',1,'Youtube.com'

select * from Video

create procedure sp_video_eliminar
@idVideo int
AS
Begin 
	delete from Video where idVideo=@idVideo
END

create procedure sp_video_actualizar
@idVideo int,
@titulo varchar(100),
@repro int,
@url varchar(100)
AS
BEGIN
UPDATE Video set titulo=@titulo,repro=@repro,url=@url where idVideo=@idVideo
END;