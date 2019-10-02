ALTER PROCEDURE [dbo].[spObtenerUltimoSorteo]
@Resultado varchar(36) Output
as
declare @Fecha as smalldatetime
select @Fecha =  max(Fecha) from sorteos

select @Resultado = SorteoTra from sorteos where Fecha = @Fecha
select @Resultado = @Resultado + SorteoDes from sorteos where Fecha = @Fecha
select @Resultado = @Resultado + SorteoSal from sorteos where Fecha = @Fecha