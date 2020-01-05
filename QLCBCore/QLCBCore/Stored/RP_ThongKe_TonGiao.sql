USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[RP_ThongKe_TonGiao]    Script Date: 05/01/2020 10:10:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--    RP_ThongKe_TonGiao 10
ALTER PROCEDURE [dbo].[RP_ThongKe_TonGiao]
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

-- Bảng tạm tôn giáo
		IF OBJECT_ID('tempdb..#dmTonGiao') IS NOT NULL  BEGIN  DROP TABLE #dmTonGiao END 
		CREATE TABLE #dmTonGiao (ID int )  
		INSERT INTO #dmTonGiao
		SELECT id from dmTonGiaos where IsDeleted = 0
   
-- Danh sách đơn vị con của @iDonViID
select *  INTO #dmDonviTmp from dmDonVis where IsDeleted = 0 
-- Danh sách cán bộ 
select * into #DSCB from CanBos as cb
where KieuCanBo in (select KieuCB from #KieuCanBo)

-- Danh sach Select CanBo
SELECT
  ID,
  TenDonVi,
  Leve,
  MaCha,
  KieuDonVi,
  STT,
  CAST(0 AS int) AS TongSo,
  CAST(0 AS int) AS CoTonGiao,
  CAST(0 AS int) AS KhongTonGiao 
  INTO #TongsoCanBo
FROM #dmDonviTmp order by MaCha,STT

--Tong so can bo của đơn vị
UPDATE #TongsoCanBo 
SET #TongsoCanBo.TongSo = 
(
	select ISNULL(sum(total), 0 ) from 
	(
		select DonViId, count(1) as total from #DSCB as cb
		INNER JOIN dmTonGiaos as dmTG ON cb.TonGiaoID = dmTG.ID 
		group by DonViId
	) as t2
		where t2.DonViID in 
		(
			select ID from dmDonVis 
		)
)

UPDATE #TongsoCanBo 
SET #TongsoCanBo.CoTonGiao = 
(
	select ISNULL(sum(total), 0 ) from 
	(
		--select DonViId, count(1) as total from #DSCB as cb
		--INNER JOIN dmTonGiao as dmTG ON cb.TonGiaoID = dmTG.ID  and cb.TonGiaoID in (select ID from #dmTonGiao)
		--group by DonViId
		select DonViId, count(1) as total from #DSCB as cb
		INNER JOIN dmTonGiaos as dmTG ON cb.TonGiaoID = dmTG.ID  and cb.TonGiaoID in (select ID from #dmTonGiao where ID!=1 )
		group by DonViId
	) as t2
	where t2.DonViID in 
	(
		select ID from dmDonVis 
	)
)
UPDATE #TongsoCanBo 
SET #TongsoCanBo.KhongTonGiao = 
(
	select ISNULL(sum(total), 0 ) from 
	(
		--select DonViId, count(1) as total from #DSCB as cb
		--INNER JOIN dmTonGiao as dmTG ON cb.TonGiaoID = dmTG.ID  and cb.TonGiaoID in (select ID from #dmTonGiao)
		--group by DonViId
		select DonViId, count(1) as total from #DSCB as cb
		INNER JOIN dmTonGiaos as dmTG ON cb.TonGiaoID = dmTG.ID  and cb.TonGiaoID =1
		group by DonViId
	) as t2
	where t2.DonViID in 
	(
		select ID from dmDonVis 
	)
)

	select top 1 * from #TongsoCanBo