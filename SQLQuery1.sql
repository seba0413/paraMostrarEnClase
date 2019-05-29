--CREA LA BASE DE DATOS
create database base1

--USA LA BASE DE DATOS CREADA
use base1

--CREA LA TABLA ARTICULOS CON LOS CAMPOS CODIGO, DESCRIPCION Y PRECIO
CREATE TABLE articulos (
    codigo int IDENTITY(1,1) PRIMARY KEY,
    descripcion varchar(50),
    cantidad int
);

--INSERTA UN REGISTRO EN LA TABLA
insert into articulos (descripcion, cantidad) values ('monitor', 100)

--ELIMINA UN REGISTRO DE LA TABLA
--delete from articulos where codigo = 1

--SELECCIONA TODOS LOS REGISTROS DE LA TABLA CON TODOS SUS CAMPOS
select * from articulos



