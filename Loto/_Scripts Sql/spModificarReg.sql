CREATE procedure [dbo].[spModificarReg]
@NumSorteo numeric, @Fecha datetime=null,
@SorteoTra numeric(12,0)=null, @SorteoDes numeric(12,0)=null, @SorteoSal numeric(12,0)=null
as
update Sorteos set Fecha = @Fecha, SorteoTra = @SorteoTra, SorteoDes = @SorteoDes, SorteoSal = @SorteoSal where NumSorteo = @NumSorteo
