ALTER PROCEDURE [dbo].[spBuscarSorteo]
@NumSorteo int, @Sorteo varchar(12), @Fecha1 datetime, @Fecha2 datetime
as		
if not @NumSorteo is null
	select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from sorteos where NumSorteo = @NumSorteo order by Fecha
else if @Sorteo is null																				--> Primer y segundo parámetro null, tercero y cuarto no.
	select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from sorteos where (Fecha between @Fecha1 and @Fecha2) order by Fecha
else if (@Fecha1 is not null  and @Fecha2 is not null)								--> Ningún parámetro es null, las fechas nunca pueden ser null.
	begin
		set @Sorteo = @Sorteo + '%'
		select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where (SorteoTra like @Sorteo or SorteoDes like @Sorteo or SorteoSal like @Sorteo) and (Fecha between @Fecha1 and @Fecha2) order by Fecha
	end
else if @Sorteo is not null and ((@Fecha1 is null) and (@Fecha2 is  null))	--> Primer parámetro no null, segundo y tercero null.
	begin
		select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where NumSorteo = @Sorteo
	end
	
-- exec spBuscarSorteo 1122,null, null, null
-- exec spBuscarSorteo null, '020708', "19931003", "20191127"
-- exec spBuscarSorteo null, null, "19931003", "20191127"
-- select * from sorteos where SorteoTra like '12121212121%'
-- select * from sorteos where Fecha is Null
-- ───────────────────────────────────────────────────────────────────────────────
/* ALTER PROCEDURE [dbo].[spBuscarSorteo]
@Sorteo varchar(12), @Fecha1 datetime, @Fecha2 datetime
as		
if @Sorteo is null																						--> Primer parámetro null, segundo y tercero no
	select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from sorteos where (Fecha between @Fecha1 and @Fecha2) order by Fecha
else if (@Fecha1 is not null  and @Fecha2 is not null)								--> ningún parámetro es nulll
	begin
		set @Sorteo = @Sorteo + '%'
		select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where (SorteoTra like @Sorteo or SorteoDes like @Sorteo or SorteoSal like @Sorteo) and (Fecha between @Fecha1 and @Fecha2) order by Fecha
	end
else if @Sorteo is not null and ((@Fecha1 is null) and (@Fecha2 is  null))	--> Primer parámetro no null, segundo y tercero null
	begin
		select NumSorteo, CONVERT(VARCHAR(10), Fecha, 103), SorteoTra, SorteoDes, SorteoSal from Sorteos where NumSorteo = @Sorteo
	end */
