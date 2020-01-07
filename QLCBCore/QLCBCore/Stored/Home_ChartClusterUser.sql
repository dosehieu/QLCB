USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[Home_ChartClusterUser]    Script Date: 1/7/2020 9:28:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Home_ChartClusterUser 
ALTER proc [dbo].[Home_ChartClusterUser]
as		

SELECT  COUNT(CanBos.ID) TongSo,
		COUNT(Case When CanBos.KieuCanBo = 1 Then KieuCanBo End) CongChuc,
		COUNT(Case When CanBos.KieuCanBo = 2 Then KieuCanBo End) VienChuc,
		COUNT(Case When KieuCanBo = 3 Then KieuCanBo End) HopDong,
	   COUNT(Case When KieuCanBo = 4 Then KieuCanBo End) HopDong68
	
	FROM CanBos 	
	WHERE CanBos.TrangThai = 0 and CanBos.IsDeleted = 0 and KieuCanBo in (1,2,3,4) and
	CanBos.DonViID in (select dmDonVis.ID from dmDonVis where dmDonVis.IsDeleted = 0 )