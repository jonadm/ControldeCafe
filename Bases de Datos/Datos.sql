use Control_Cafe;

select * from usuario;
exec dbo.usuario_insert '1','DMM','546'

--exec dbo.usuario_delete '1'

select * from area;
exec dbo.area_insert '1','Produccion'

select * from marca;
exec dbo.marca_insert '1',''

select * from tipo_persona
exec dbo.tpersona_insert '1','Empleado'
exec dbo.tpersona_insert '2','Cliente'
exec dbo.tpersona_insert '3','Proveedor'


select * from tipo_producto
exec dbo.tproducto_insert '1',''


select * from tipo_persona

select * from marca;

select * from area;

select * from compra;

select * from empleado;

select * from inventario;

select * from persona;

select * from producto;

select * from proveedor;

select * from usuario;



