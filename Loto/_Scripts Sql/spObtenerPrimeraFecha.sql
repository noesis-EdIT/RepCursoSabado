USE [Loto]
GO
/****** Object:  StoredProcedure [dbo].[spObtenerPrimeraFecha]    Script Date: 09/25/2015 14:42:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[spObtenerPrimeraFecha]
@Resultado datetime Output
as  
select @Resultado =  convert(varchar(8), min(Fecha), 112) from Sorteos
--return
GO
