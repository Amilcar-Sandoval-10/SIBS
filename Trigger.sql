Create trigger InsertarCompra
on Factura_Compras
for insert
as
set nocount on
begin
declare @Cantidad int
declare @ID int
select @Cantidad =Cantidad from inserted
Select @ID= ID From inserted
Update Inventario set StockActual=(Inventario.StockActual + (@Cantidad)) 
where Cod_Inventario = (@ID)
end
go

select * from Factura_Compras
select * from Inventario
select * from FACTURA

alter trigger InsertarVenta
on FACTURA
for insert
as
set nocount on
begin
declare @Cantidad int
declare @ID int
select @Cantidad =Cantidad from inserted
Select @ID= ID From inserted
Update Inventario set StockActual=(Inventario.StockActual - (@Cantidad)) 
where Cod_Inventario = (@ID)
end
go
