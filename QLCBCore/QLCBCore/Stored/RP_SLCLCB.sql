USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[RP_SLCLCB_v3]    Script Date: 03/01/2020 10:16:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- [RP_SLCLCB] '2019-11-29'
ALTER PROCEDURE [dbo].[RP_SLCLCB]
@DenNgay datetime
AS

-- LẤy danh sách cán bộ 3 cấp đầu tiên
select * into #dmDonviTmp from dmDonVis

-- TAO BANG DANH SACH CAN BO
SELECT t1.ID,DonViId,GioiTinh,NgayVaoDang,DanTocID,TonGiaoID,NgaySinh INTO #DanhSachCanBo from CanBos as t1 
INNER JOIN dmTonGiaos on dmTonGiaos.ID = t1.TonGiaoID
where dmTonGiaos.IsDeleted = 0

SELECT
  ID,
  TenDonVi,
  Leve,
  MaCha,
  KieuDonVi,
  STT,
  CAST(0 AS int) AS TongSo,
  CAST(0 AS int) PhuNu,
  CAST(0 AS int) Nam,
  CAST(0 AS int) AS Total20den30,
  CAST(0 AS int) AS Namtu20den30,
  CAST(0 AS int) AS Nutu20den30,
  CAST(0 AS int) AS Total30den50,
  CAST(0 AS int) AS Namtu30den50,
  CAST(0 AS int) AS Nutu30den50,
  CAST(0 AS int) AS Totaltren50,
  CAST(0 AS int) AS Namtren50,
  CAST(0 AS int) AS Nutren50
  INTO #TongsoCanBo
FROM #dmDonviTmp order by ID;

-- TINH TOAN SO LIEU VA UPDATE LAI VAO BANG TAM TONG SO CAN BO
--Tong So cán bộ biên chế
UPDATE #TongsoCanBo 
SET #TongsoCanBo.TongSo = (select ISNULL(sum(total), 0 ) from (
select DonViId, count(1) as total from #DanhSachCanBo as dscb  
group by DonViId) as t2
where t2.DonViID = #TongsoCanBo.ID)

--Can bo Nu biên chế
UPDATE #TongsoCanBo 
SET #TongsoCanBo.PhuNu = (select ISNULL(sum(total), 0 ) from (
select DonViId, count(1) as total from #DanhSachCanBo as dscb where ISNULL(GioiTinh, 0) = 0 group by DonViId) as t2
where t2.DonViID = #TongsoCanBo.ID)

--Can bo Nam biên chế
UPDATE #TongsoCanBo 
SET #TongsoCanBo.Nam = (select ISNULL(sum(total), 0 ) from (
select DonViId, count(1) as total from #DanhSachCanBo as dscb where ISNULL(GioiTinh, 0) = 1 group by DonViId) as t2
where t2.DonViID = #TongsoCanBo.ID)


select DonViId
,ISNULL(sum(Total20den30), 0 ) as Total20den30
,ISNULL(sum(Nam20den30), 0 ) as Nam20den30
,ISNULL(sum(Nu20den30), 0 ) as Nu20den30 
,ISNULL(sum(Total30den50), 0 ) as Total30den50 
,ISNULL(sum(Nam30den50), 0 ) as Nam30den50 
,ISNULL(sum(Nu30den50), 0 ) as Nu30den50
,ISNULL(sum(Totaltren50), 0 ) as Totaltren50
,ISNULL(sum(Namtren50), 0 ) as Namtren50
,ISNULL(sum(Nutren50), 0 ) as Nutren50
INTO #TempDoTuoi
from
	(select DonViId, 
	case when CAST(@DenNgay AS smalldatetime) BETWEEN dateadd(DAY,1,DATEADD(YEAR, 20, NgaySinh)) AND DATEADD(YEAR, 30, NgaySinh) then COUNT(1) end Total20den30,
	case when CAST(@DenNgay AS smalldatetime) BETWEEN dateadd(DAY,1,DATEADD(YEAR, 20, NgaySinh)) AND DATEADD(YEAR, 30, NgaySinh) AND GioiTinh = 0 then COUNT(1) end Nu20den30,
	case when CAST(@DenNgay AS smalldatetime) BETWEEN dateadd(DAY,1,DATEADD(YEAR, 20, NgaySinh)) AND DATEADD(YEAR, 30, NgaySinh) AND GioiTinh = 1 then COUNT(1) end Nam20den30,
	case when CAST(@DenNgay AS smalldatetime) BETWEEN dateadd(DAY,1,DATEADD(YEAR, 30, NgaySinh)) AND DATEADD(YEAR, 50, NgaySinh) then COUNT(1) end Total30den50,
	case when CAST(@DenNgay AS smalldatetime) BETWEEN dateadd(DAY,1,DATEADD(YEAR, 30, NgaySinh)) AND DATEADD(YEAR, 50, NgaySinh) AND GioiTinh = 0 then COUNT(1) end Nu30den50,
	case when CAST(@DenNgay AS smalldatetime) BETWEEN dateadd(DAY,1,DATEADD(YEAR, 30, NgaySinh)) AND DATEADD(YEAR, 50, NgaySinh) AND GioiTinh = 1 then COUNT(1) end Nam30den50,
	case when (DATEADD(YEAR, 50, NgaySinh) < CAST(@DenNgay AS smalldatetime)) then COUNT(1) end Totaltren50,
	case when (DATEADD(YEAR, 50, NgaySinh) < CAST(@DenNgay AS smalldatetime)) AND GioiTinh = 0 then COUNT(1) end Nutren50,
	case when (DATEADD(YEAR, 50, NgaySinh) < CAST(@DenNgay AS smalldatetime)) AND GioiTinh = 1 then COUNT(1) end Namtren50
	from #DanhSachCanBo as dscb  
	group by DonViId,NgaySinh,GioiTinh) as t2 
group by t2.DonViID

UPDATE #TongsoCanBo
SET #TongsoCanBo.Total20den30 = (select ISNULL(SUM(t2.Total20den30),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Namtu20den30 = (select ISNULL(SUM(t2.Nam20den30),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Nutu20den30 = (select ISNULL(SUM(t2.Nu20den30),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Total30den50 = (select ISNULL(SUM(t2.Total30den50),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Nutu30den50 = (select ISNULL(SUM(t2.Nu30den50),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Namtu30den50 = (select ISNULL(SUM(t2.Nam30den50),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Totaltren50 = (select ISNULL(SUM(t2.Totaltren50),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Namtren50 = (select ISNULL(SUM(t2.Namtren50),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)

UPDATE #TongsoCanBo
SET #TongsoCanBo.Nutren50 = (select ISNULL(SUM(t2.Nutren50),0)  
FROM #TempDoTuoi t2
where t2.DonViID = #TongsoCanBo.ID)
 
SELECT * FROM #TongsoCanBo ORDER BY STT asc
DROP TABLE #TongsoCanBo 