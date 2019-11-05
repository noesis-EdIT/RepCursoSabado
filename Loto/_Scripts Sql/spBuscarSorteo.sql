ALTER PROCEDURE [dbo].[spBuscarSorteo]
@Sorteo varchar(12), @Fecha1 datetime, @Fecha2 datetime
as		
if @Sorteo is null
	select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from sorteos where (Fecha between @Fecha1 and @Fecha2) order by Fecha
else if (@Fecha1 is not null  and @Fecha2 is not null)
	begin
		set @Sorteo = @Sorteo + '%'
		select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where (SorteoTra like @Sorteo or SorteoDes like @Sorteo or SorteoSal like @Sorteo) and (Fecha between @Fecha1 and @Fecha2) order by Fecha
	end
else if ((@Fecha1 is null) and (@Fecha2 is  null))
	begin
		select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where NumSorteo = @Sorteo
	end
else if @Sorteo is not null and ((@Fecha1 is null) and (@Fecha2 is  null))
	begin
		select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where NumSorteo = @Sorteo
	end

-- create procedure [dbo].[sorteobuscar]
-- @Sorteo varchar(12), @Fecha1 datetime, @Fecha2 datetime
-- as		
-- if @Sorteo is null
	-- select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from sorteos where (Fecha between @Fecha1 and @Fecha2) order by Fecha
-- else
	-- set @Sorteo = @Sorteo + '%'
	-- select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where (SorteoTra like @Sorteo or SorteoDes like @Sorteo or SorteoSal like @Sorteo) and (Fecha between @Fecha1 and @Fecha2) order by Fecha

		
-- exec SorteoBuscar '5', "19000101", "19000120"
-- exec SorteoBuscar null, "19000101", "19850110"
-- select * from sorteos where SorteoTra like '12121212121%'
-- select * from sorteos where Fecha is Null
