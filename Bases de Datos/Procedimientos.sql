use Control_Cafe;
	
create procedure area_insert
@id_area varchar(10),
@Descripción varchar (50)
as
begin
insert into dbo.area
values (@id_area,@Descripción)
end
go


create procedure compra_insert
@id_compra varchar(10),@cantidad varchar(50), @producto_id_Produc varchar(10), @proveedor_id_provee varchar(10)
as
begin
insert into dbo.compra
values (@id_compra,@cantidad,@producto_id_Produc,@proveedor_id_provee)
end
go

create procedure empleado_insert 
@id_emple varchar(10),@f_ingreso date, @area_id_area varchar(10), @persona_id_persona varchar(10)
as
begin
insert into dbo.empleado
values (@id_emple,@f_ingreso,@area_id_area,@persona_id_persona)
end
go


create procedure inventario_insert
@id_inven varchar(10),@cantida varchar(50),@producto_id_produc varchar(10),@compra_id_compra varchar(10)
as
begin
insert into dbo.inventario
values (@id_inven,@cantida,@producto_id_produc,@compra_id_compra)
end
go

create procedure marca_insert
@id_marca varchar(10),@descripcion varchar(50)
as
begin
insert into dbo.marca
values (@id_marca,@descripcion)
end
go

create procedure persona_insert
@id_persona varchar(10),@nombre varchar(50),@apellido varchar(50),@dpi varchar(50),@direccion varchar(50),@tipo_persona_id_tpers varchar(10)
as
begin
insert into dbo.persona
values (@id_persona,@nombre,@apellido,@dpi,@direccion,@tipo_persona_id_tpers)
end 
go

create procedure producto_insert
@id_produc varchar(10),@nombre varchar(50),@tipo_producto_id_produc varchar(10),@marca_id_marca varchar(10)
as
begin
insert into dbo.producto
values (@id_produc,@nombre,@tipo_producto_id_produc,@marca_id_marca)
end
go

create procedure proveedor_insert
@id_provee varchar(10),@persona_id_persona varchar(10)
as
begin
insert into dbo.proveedor
values (@id_provee,@persona_id_persona)
end
go

create procedure tpersona_insert
@id_tpers varchar(10),@descripcion varchar(50)
as
begin
insert into dbo.tipo_persona
values (@id_tpers,@descripcion)
end
go

create procedure usuario_insert
@id_usuario varchar(10),@nomb_usuario varchar(50),@contraseña varchar(50)
as
begin
insert into dbo.usuario
values (@id_usuario,@nomb_usuario,@contraseña)
end
go




create procedure area_actualizar
@id_area varchar(10),@Descripción varchar (50)
as
begin
update dbo.area
set descripcion=@Descripción
where id_area=@id_area
end


create procedure compra_actualizar
@id_compra varchar(10),@cantidad varchar(50), @producto_id_Produc varchar(10), @proveedor_id_provee varchar(10)
as
begin
update dbo.compra
set cantidad=@cantidad,producto_id_produc=@producto_id_Produc,proveedor_id_provee=@proveedor_id_provee
where id_compra=@id_compra
end

create procedure empleado_actualizar
@id_emple varchar(10),@f_ingreso date, @area_id_area varchar(10), @persona_id_persona varchar(10)
as
begin
update dbo.empleado
set f_ingreso=@f_ingreso,area_id_area=@area_id_area,persona_id_persona=@persona_id_persona
where id_emple=@id_emple
end

create procedure inventario_actualizar
@id_inven varchar(10),@cantidad varchar(50),@producto_id_produc varchar(10),@compra_id_compra varchar(10)
as
begin
update dbo.inventario
set cantidad=@cantidad,producto_id_produc=@producto_id_produc,compra_id_compra=@compra_id_compra
where id_inven=@id_inven
end

create procedure marca_actualizar
@id_marca varchar(10),@descripcion varchar(50)
as
begin
update dbo.marca
set descripcion=@descripcion
where id_marca=@id_marca
end

create procedure persona_actualizar
@id_persona varchar(10),@nombre varchar(50),@apellido varchar(50),@dpi varchar(50),@direccion varchar(50),@tipo_persona_id_tpers varchar(10)
as
begin
update dbo.persona
set nombre=@nombre,apellido=@apellido,dpi=@dpi,direccion=@direccion,tipo_persona_id_tpers=@tipo_persona_id_tpers
where id_persona=@id_persona
end 

create procedure producto_actualizar
@id_produc varchar(10),@nombre varchar(50),@tipo_producto_id_produc varchar(10),@marca_id_marca varchar(10)
as
begin
update dbo.producto
set nombre=@nombre,tipo_producto_id_tproduc=@tipo_producto_id_produc,marca_id_marca=@marca_id_marca
where id_produc=@id_produc
end

create procedure proveedor_actualizar
@id_provee varchar(10),@persona_id_persona varchar(10)
as
begin
update dbo.proveedor
set persona_id_persona=@persona_id_persona
where id_provee=@id_provee
end

create procedure tpersona_actualizar
@id_tpers varchar(10),@descripcion varchar(50)
as
begin
update dbo.tipo_persona
set descripcion=@descripcion
where id_tpers=@id_tpers
end

create procedure usuario_actualizar
@id_usuario varchar(10),@nomb_usuario varchar(50),@contraseña varchar(50)
as
begin
update dbo.usuario
set nomb_usuario=@nomb_usuario,contraseña=@contraseña
where id_usuario=@id_usuario
end



drop procedure area_actualizar;




create procedure area_delete
@id_area varchar(10)
as
begin
delete from area where id_area=@id_area
end


create procedure compra_delete
@id_compra varchar(10)
as
begin
delete from compra where id_compra=@id_compra
end

create procedure empleado_delete
@id_emple varchar(10)
as
begin
delete from empleado where id_emple=@id_emple
end


create procedure inventario_delete
@id_inven varchar(10)
as
begin
delete from inventario where id_inven=@id_inven
end

create procedure marca_delete
@id_marca varchar(10)
as
begin
delete from marca where id_marca=@id_marca
end

create procedure persona_delete
@id_persona varchar(10)
as
begin
delete from persona where id_persona=@id_persona
end

create procedure producto_delete 
@id_produc varchar(10)
as
begin
delete from producto where id_produc=@id_produc
end

create procedure proveedor_delete
@id_provee varchar(10)
as
begin
delete from proveedor where id_provee=@id_provee
end

create procedure tpersona_delete
@id_tpers varchar(10)
as
begin
delete from tipo_persona where id_tpers=@id_tpers
end 

create procedure usuario_delete
@id_usuario varchar(10)
as
begin
delete from usuario where id_usuario=@id_usuario
end


























