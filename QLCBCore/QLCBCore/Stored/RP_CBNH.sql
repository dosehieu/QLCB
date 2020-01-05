USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[RP_CBNH]    Script Date: 04/01/2020 15:47:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- RP_CBNH  '2000-01-01', 10
ALTER PROCEDURE [dbo].[RP_CBNH](
	@toDate datetime,
	@KieuCB int
	)
AS 
		DECLARE	@sql NVARCHAR(2000);
		--sửa đây
		SELECT CAST(0 as tinyint) KieuCB INTO #KieuCanBo
		IF(@KieuCB = -1) -- cả 4 kiểu 
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

-- Danh sách cây đơn vị		
select * into #DsDonVi from dmDonVis where IsDeleted = 0
-- TAO BANG DANH SACH CAN BO
SELECT * 
INTO #DanhSachCanBo
from CanBos as cb
WHERE cb.TrangThai = 0 and cb.KieuCanBo in (select KieuCB from #KieuCanBo)

-- lẤY TỔNG SỐ CÁN BỘ CỦA CÂY ĐƠN VỊ
select t1.ID, t1.HoTen,
t2.ID as DonViID, t2.TenDonVi,
(case when GioiTinh = 1 then cast(NgaySinh as datetime2) end) as NgaySinh_Nam,(case when GioiTinh = 0 then cast(NgaySinh as datetime2) end) as NgaySinh_Nu,
dmChucVu.TenChucVu,
dmNgachs.MaNgach,
t5.HeSo,
case t1.GioiTinh when 1 then DATEADD(month,6,DATEADD(year, 59, cast(t1.NgaySinh as datetime2))) else DATEADD(month,6,DATEADD(year, 54, cast(t1.NgaySinh as datetime2))) end AS NgayThongBaoNghiHuu,
case t1.GioiTinh when 1 then DATEADD(year, 60, cast(t1.NgaySinh as datetime2)) else DATEADD(year, 55, cast(t1.NgaySinh as datetime2)) end AS NgayNghiHuu
into #TempTable
from #DanhSachCanBo as t1
LEFT JOIN #DsDonVi as t2 ON t1.DonViID = t2.ID
-- Chức vụ
OUTER APPLY (select top 1 * from DienBienChucVus as p where t1.ID = p.CanBoID and p.IsDeleted=0 order by p.DenNgay asc) as t3
LEFT JOIN dmChucVus as dmChucVu ON t3.ChucVuID = dmChucVu.ID

OUTER APPLY (select top 1 * from DienBienNgachBacs as p where t1.ID = p.CanBoID and p.IsDeleted=0 order by p.NgayKetThuc asc) as t5
LEFT JOIN dmNgachs ON t5.NgachID = dmNgachs.ID
where 

(
	(t1.GioiTinh = 1 and DATEADD(year, 60, cast(t1.NgaySinh as datetime2)) <= cast(@toDate as datetime2))
	OR
	((t1.GioiTinh = 0 and DATEADD(year, 55, cast(t1.NgaySinh as datetime2)) <= cast(@toDate as datetime2)))
	)

	SET @sql = 'SELECT DISTINCT * FROM #TempTable order by HoTen' 
	EXEC (@sql)