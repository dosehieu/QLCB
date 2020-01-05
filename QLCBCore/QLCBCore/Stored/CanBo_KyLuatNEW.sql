USE [QLCB]
GO
/****** Object:  StoredProcedure [dbo].[CanBo_KyLuatNEW]    Script Date: 04/01/2020 14:03:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--	[CanBo_KyLuatNEW] 2019
ALTER PROCEDURE [dbo].[CanBo_KyLuatNEW]
	@iYear int=0
AS
BEGIN
		
	IF OBJECT_ID('tempdb..#tempCanBo') IS NOT NULL DROP TABLE #tempCanBo
	IF OBJECT_ID('tempdb..#dmDonviTmp') IS NOT NULL DROP TABLE #dmDonviTmp
	DECLARE	@sql NVARCHAR(2000);
	DECLARE @StartRecord INT;


	WITH SelectDonViRecursive AS(
			SELECT * FROM dmDonVis
			UNION ALL
			SELECT dv.* FROM dmDonVis dv INNER JOIN SelectDonViRecursive sk ON dv.MaCha = sk.ID
		)

	SELECT * INTO #dmDonviTmp FROM SelectDonViRecursive 
	SELECT dmDonviTmp.TenDonVi AS DonVi,dtd.ID as TenTrinhDo, CanBos.KieuCanBo, dmKieuCanBo.TenKieuCanBo,dmDonviTmp.ID,ISNULL(dmChucVus.STT,9999) as ChucVuSTT,    dbo.CanBos.ID AS CanBoID, UPPER(dbo.CanBos.HoTen) as HoTen, dbo.CanBos.NgaySinh, dbo.CanBos.GioiTinh, 
		dv.TenDonVi, dmDonviTmp.TenDonVi as TenPhongBan, dmChucVus.ID as ChucVuID,dmChucVus.TenChucVu as TenChucVu ,dbo.CanBos.RegionID, 
		kt.NgayKyLuat Nam, kt.NoiDung NoiDung, dmkt.TenKyLuat  HinhThucKyLuat
		into #tempCanBo
	FROM dbo.CanBos inner join #dmDonviTmp dmDonviTmp ON dbo.CanBos.DonViID = dmDonviTmp.ID 
		INNER JOIN QTKyLuats kt ON CanBos.ID = kt.CanBoID and kt.IsCaoNhat= 'true'
		INNER JOIN dmKyLuats dmkt ON kt.KyLuatID = dmkt.ID
		inner join dmKieuCanBo on dmKieuCanBo.ID= CanBos.KieuCanBo
		left join dmDonVis dv ON dv.ID = dmDonviTmp.ID
		left join dmChucVus on CanBos.ChucVuID = dmChucVus.ID
		left JOIN dmTrinhDos dtd ON CanBos.TrinhDoID = dtd.ID
	WHERE CanBos.TrangThai=0 AND YEAR(kt.NgayKyLuat) = @iYear and CanBos.KieuCanBo in (select ID from dmKieuCanBo where IsDeleted=0)
	and CanBos.IsDeleted=0 and dmDonviTmp.IsDeleted=0 and dmkt.IsDeleted=0
	--group by HoTen	
	order by dv.STT, dmDonviTmp.TenDonVi, HoTen
	
	SELECT  * FROM #tempCanBo

END
