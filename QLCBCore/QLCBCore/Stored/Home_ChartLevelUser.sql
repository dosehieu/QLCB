USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[Home_ChartLevelUser]    Script Date: 1/7/2020 9:39:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--[dbo].[Home_ChartLevelUser] 
ALTER proc [dbo].[Home_ChartLevelUser]
as

select COUNT(t1.ID) TongSo,
		COUNT(Case When TrinhDoID = 1 Then TrinhDoID End) TienSy,
		COUNT(Case When TrinhDoID = 2 Then TrinhDoID End) ThacSy,
		COUNT(Case When TrinhDoID = 3 Then TrinhDoID End) DaiHoc,
		COUNT(Case When TrinhDoID = 4 Then TrinhDoID End) CuNhan,
		COUNT(Case When TrinhDoID = 5 Then TrinhDoID End) CaoDang,
		COUNT(Case When TrinhDoID = 6 Then TrinhDoID End) TrungCap,
		COUNT(Case When TrinhDoID not in (1,2,3,4,5,6) Then TrinhDoID End) Khac
from CanBos as t1