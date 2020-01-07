USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[Home_ChartGender]    Script Date: 1/7/2020 9:09:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--[dbo].[Home_ChartGender]
ALTER proc [dbo].[Home_ChartGender]
as
Begin
	SELECT  Count(t1.ID) as TongSo, COUNT(Case When t1.GioiTinh = 1 Then t1.ID End) TongSoNam 
	FROM CanBos as t1
End
