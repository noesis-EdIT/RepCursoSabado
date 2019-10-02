CREATE Procedure [dbo].[spObtenerUltimaFecha]
@Resultado datetime Output
as  
select @Resultado =  convert(varchar(8), max(Fecha), 112) from Sorteos
GO
