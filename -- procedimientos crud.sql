-- procedimientos crud

-- ==========================INSERTAR==============================
create procedure Insertar
@variable1 tipoDato,
@variable2 tipoDato
as
begin
    insert into NombreTabla(Capo1,Campo2) values (@variable1,variable2)
end

-- ==========================ACTUALIZAR==============================
create procedure Actualizar
@id int
@variable1 tipoDato,
@variable2 tipoDato
as
begin
    update NombreTabla
    set datoTabla1=@variable1,datoTabla2=variable2
    where idTabla=@id
end

-- ==========================CONSULTAR UNO==============================
create procedure Consultar1
@id int
as
begin
    select * from NombreTabla
    where idTabla=@id
end

-- ==========================ELIMINAR==============================
create procedure Eliminar
@id int
as
begin
    delete from NombreTabla
    where idTabla=@id
end

-- ejecutar procedure
EXEC nombre_procedimiento argumentos;