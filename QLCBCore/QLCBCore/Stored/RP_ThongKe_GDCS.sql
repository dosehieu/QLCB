USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[RP_ThongKe_GDCS]    Script Date: 05/01/2020 11:49:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  [RP_ThongKe_GDCS]  10
ALTER PROCEDURE [dbo].[RP_ThongKe_GDCS]
(
	@KieuCB int 
)
as 

--sửa đây
		SELECT CAST(0 as tinyint) KieuCB INTO #KieuCanBo
		IF(@KieuCB = 10) -- cả 4 kiểu 
		Begin
			INSERT INTO #KieuCanBo 
			select ID from dmKieuCanBo where IsDeleted = 0
			DELETE #KieuCanBo WHERE KieuCB=0
		End
		ELSE
		IF(@KieuCB = 0)
		Begin
			INSERT INTO #KieuCanBo 
			select ID from dmKieuCanBo where ID in (1,2) and IsDeleted = 0
			DELETE #KieuCanBo WHERE KieuCB=0
		End
		ELSE 
			INSERT INTO #KieuCanBo VALUES(@KieuCB)--sửa đến đây 


	SELECT t1.ID,t1.HoTen,t1.KieuCanBo, dmG.TenGiaDinhCS, dmG.ID as ID_GDCS
	into #dscanbo
	FROM CanBos as t1 
-- Diễn biến ngạch bậc
	
	LEFT JOIN dmGiaDinhCSs as dmG ON t1.GiaDinhCSID = dmG.ID and dmG.IsDeleted = 0
	where dmG.TenGiaDinhCS is not null and  t1.KieuCanBo in (select KieuCB from #KieuCanBo)
	and t1.IsDeleted != 1
	--select * from #dscanbo

	select  dmGiaDinhCSs.ID, dmGiaDinhCSs.TenGiaDinhCS as TenGDCS,count(#dscanbo.ID_GDCS) as count_num  from dmGiaDinhCSs
	left join  #dscanbo on #dscanbo.ID_GDCS= dmGiaDinhCSs.ID where dmGiaDinhCSs.IsDeleted != 'true'
	group by dmGiaDinhCSs.ID,dmGiaDinhCSs.TenGiaDinhCS
