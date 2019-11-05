USE [Loto]
GO
/****** Object:  StoredProcedure [dbo].[spAgregarReg]    Script Date: 05/15/2017 23:32:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[spAgregarReg]
@NumSorteo numeric=null, @Fecha datetime=null,
@SorteoTra varchar(12), @SorteoDes varchar(12), @SorteoSal varchar(12)
as
--insert into Sorteos values (@NumSorteo, CONVERT(Varchar(10),@Fecha,103), @SorteoTra, @SorteoDes, @SorteoSal)
insert into Sorteos values (@NumSorteo, CONVERT(Varchar(10),@Fecha,103), (replicate('0', 12-datalength(@SorteoTra)) + @SorteoTra), (replicate('0', 12-datalength(@SorteoDes)) + @SorteoDes), (replicate('0', 12-datalength(@SorteoSal)) + @SorteoSal))