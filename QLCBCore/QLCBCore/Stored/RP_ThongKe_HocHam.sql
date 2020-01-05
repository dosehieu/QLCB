USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[RP_ThongKe_HocHam]    Script Date: 05/01/2020 12:02:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  [RP_ThongKe_HocHam] 10
ALTER PROCEDURE [dbo].[RP_ThongKe_HocHam]
(
	@KieuCB int
)
as 
-- Bảng tạm KieuCB		
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

-- Danh sách đơn vị con của @iDonViID
select *  INTO #dmDonviTmp from dmDonVis where IsDeleted = 0
-- Danh sách cán bộ 
select * into #DSCB from CanBos as cb where KieuCanBo in (select KieuCB from #KieuCanBo)

-- Danh sach Select CanBo
SELECT
  ID,
  TenDonVi,
  STT,
CAST(0 AS int) AS TongSo,
CAST(0 AS int) AS GiaoSu,
CAST(0 AS int) AS PhoGiaoSu,
CAST(0 AS int) AS Khac
  INTO #TongsoCanBo
FROM #dmDonviTmp order by MaCha,STT

--Tong so can bo của đơn vị
UPDATE #TongsoCanBo 
SET #TongsoCanBo.TongSo = 
(select ISNULL(sum(total), 0 ) from (
select DonViId, count(1) as total from #DSCB as cb
group by DonViId) as t2
where t2.DonViID in (select ID from dmDonVis ))

UPDATE #TongsoCanBo 
SET #TongsoCanBo.GiaoSu = 
(select ISNULL(sum(total), 0 ) from (
select DonViId, count(1) as total from #DSCB as cb 
where cb.HocHamID = 3
group by DonViId) as t2
where t2.DonViID in (select ID from dmDonVis ))
 
UPDATE #TongsoCanBo 
SET #TongsoCanBo.PhoGiaoSu = 
(
	select ISNULL(sum(total), 0 ) from 
	(
		select DonViId, count(1) as total from #DSCB as cb 
		where cb.HocHamID = 2
		group by DonViId
	) as t2
	where t2.DonViID in 
	(
		select ID from dmDonVis
	)
)

UPDATE #TongsoCanBo 
SET #TongsoCanBo.Khac = 
(select ISNULL(sum(total), 0 ) from (
select DonViId, count(1) as total from #DSCB as cb 
where cb.HocHamID not in (2,3) 
group by DonViId) as t2
where t2.DonViID in (select ID from dmDonVis))

select top 1 * from #TongsoCanBo
 