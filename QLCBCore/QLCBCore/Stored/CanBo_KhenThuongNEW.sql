USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[CanBo_KhenThuongNEW]    Script Date: 04/01/2020 10:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thidua
--CanBo_KhenThuongNEW 2019, 0 ,10
--KhenThuong
--CanBo_KhenThuongNEW 2019, 0,-1 
ALTER PROCEDURE [dbo].[CanBo_KhenThuongNEW](
	@iYear int=0, 
	@isKhenThuong char(1)='1',
	@KieuCB int
	)
AS
BEGIN

		IF OBJECT_ID('tempdb..#tempCanBo') IS NOT NULL DROP TABLE #tempCanBo
		IF OBJECT_ID('tempdb..#dmDonviTmp') IS NOT NULL DROP TABLE #dmDonviTmp
		IF OBJECT_ID('tempdb..#KieuCanBo') IS NOT NULL DROP TABLE #KieuCanBo
		IF OBJECT_ID('tempdb..#dsCanBo') IS NOT NULL DROP TABLE #dsCanBo
		--check theo kiểu cán bộ
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
		begin
			INSERT INTO #KieuCanBo VALUES(@KieuCB) ;
			DELETE #KieuCanBo WHERE KieuCB=0
		end
		;WITH SelectDonViRecursive AS(
				SELECT * FROM dmDonVis 
				UNION ALL
				SELECT dv.* FROM dmDonVis dv INNER JOIN SelectDonViRecursive sk ON dv.MaCha = sk.ID
			)
		SELECT * INTO #dmDonviTmp FROM SelectDonViRecursive 

		--select * from #dmDonviTmp
		SELECT dmDonviTmp.TenDonVi AS DonVi,dtd.ID as TenTrinhDo, CanBos.KieuCanBo, dmKieuCanBo.TenKieuCanBo, dmDonviTmp.ID, dbo.CanBos.ID AS CanBoID, UPPER(dbo.CanBos.HoTen) as HoTen, dbo.CanBos.NgaySinh, dbo.CanBos.GioiTinh, 
			dmDonviTmp.TenDonVi, dmDonviTmp.TenDonVi as TenPhongBan, dmChucVus.ID as TenChucVu,isnull(dmChucVus.STT ,9999)as STTChucVu, dbo.CanBos.RegionID, dmChucVus.TenChucVu ChucVu, 
			CONVERT(datetime, Ngaykhenthuong, 103) Ngaykhenthuong, kt.NoiDung NoiDungkt, dmkt.TenHinhThucKhenThuong
		INTO #dsCanBo	
		FROM dbo.CanBos inner join #dmDonviTmp dmDonviTmp ON dbo.CanBos.DonViID = dmDonviTmp.ID and dmDonviTmp.IsDeleted=0
			INNER JOIN QTKhenThuongs kt ON CanBos.ID = kt.CanBoID and kt.IsDeleted=0 
			INNER JOIN dmHinhThucKhenThuongs dmkt ON kt.HinhThucKhenThuongID = dmkt.ID and dmkt.IsDeleted=0 
			inner join dmKieuCanBo on dmKieuCanBo.ID=CanBos.KieuCanBo and dmKieuCanBo.IsDeleted=0
			left join dmDonVis dv ON dv.ID = dmDonviTmp.ID
			left join dmChucVus on CanBos.ChucVuID = dmChucVus.ID
			left JOIN dmTrinhDos dtd ON CanBos.TrinhDoID =dtd.ID
		WHERE CanBos.TrangThai =0 and CanBos.KieuCanBo in (select ID from dmKieuCanBo where IsDeleted=0)
			AND ISDATE(Ngaykhenthuong) = 1 
			AND ISNULL(kt.IsKhenThuong,0) = @isKhenThuong
		SELECT STTChucVu, DonVi, TenTrinhDo, KieuCanBo, TenKieuCanBo, ID, CanBoID, HoTen, NgaySinh, GioiTinh, TenDonVi, TenPhongBan, TenChucVu,RegionID, ChucVu, 
			YEAR(Ngaykhenthuong) Nam, NoiDungkt as NoiDung, TenHinhThucKhenThuong
			into #tempCanBo
		FROM #dsCanBo	
		WHERE Year(Ngaykhenthuong) = @iYear and #dsCanBo.KieuCanBo in (SELECT KieuCB FROM #KieuCanBo)
		order by TenPhongBan, HoTen
		SELECT  * FROM  #tempCanBo END