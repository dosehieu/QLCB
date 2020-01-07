USE [QLCB]
GO

/****** Object:  StoredProcedure [dbo].[DS_CBSHHCV]    Script Date: 1/6/2020 1:24:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--DS_CBSHHCV
CREATE PROCEDURE [dbo].[DS_CBSHHCV]
AS
BEGIN
	SET NOCOUNT ON;
	declare @month int
	if(MONTH(SYSDATETIME())=12)
	begin
		set @month =2;
	end
	else
	begin
	set @month = MONTH(SYSDATETIME()) +1;
	end
		
    -- Insert statements for procedure here
	SELECT cb.ID,HoTen,GioiTinh,NgaySinh,TenDonVi,TenChucVu,DenNgay,NgayBoNhiem from CanBos as cb
	left join dmDonVis as dv on cb.DonViID = dv.ID
	OUTER APPLY (select top 1 * from DienBienChucVus as p where cb.ID = p.CanBoID order by p.DenNgay desc) as t2
	LEFT JOIN dmChucVus as dmCV ON t2.ChucVuID = dmCV.ID
	where t2.DenNgay > SYSDATETIME() and t2.DenNgay < CAST(CAST(YEAR(SYSDATETIME()) AS varchar) + '-' + CAST(MONTH(SYSDATETIME())+2 AS varchar) + '-' + CAST(DAY(SYSDATETIME()) AS varchar) AS DATETIME)
END
GO

