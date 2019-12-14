using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class CanBo
    {
        public int ID { get; set; } // ID (Primary key)
        public string Ma { get; set; } // Ma (length: 50)
        
        //[Required(AllowEmptyStrings = true, ErrorMessage = "Không để trống")]
        //[Display(Name = "Số hiệu")]
        //[MaxLength(50)]
        //[Column("SOHIEU", TypeName = "nvarchar")]
        public string SoHieu { get; set; } // SoHieu (length: 50)

        public string HoTen { get; set; } // HoTen (length: 100)
        public string TenGoiKhac { get; set; } // TenGoiKhac (length: 100)
        public System.DateTime? NgaySinh { get; set; } // NgaySinh
        public bool? GioiTinh { get; set; } // GioiTinh
        public string NoiSinhID { get; set; } // NoiSinhID (length: 500)
        public string QueQuanID { get; set; } // QueQuanID (length: 500)
        public int? DanTocID { get; set; } // DanTocID
        public int? TonGiaoID { get; set; } // TonGiaoID
        public string HKTT { get; set; } // HKTT (length: 300)
        public string NoiO { get; set; } // NoiO (length: 300)
        public int? NgheNghiepID { get; set; } // NgheNghiepID

        ///<summary>
        /// Ngày được tuyển vào biên chế của tổng cục dân số
        ///</summary>
        public System.DateTime? NgayTD { get; set; } // NgayTD
        public string CongViecChinh { get; set; } // CongViecChinh
        public int? ChucVuID { get; set; } // ChucVuID
        public int? BacLuong { get; set; } // BacLuong
        public int? NgachID { get; set; } // NgachID

        ///<summary>
        /// Hệ số lương hiện hưởng
        ///</summary>
        public double? HeSo { get; set; } // HeSo

        ///<summary>
        /// Ngày được hưởng hệ số hiện tại
        ///</summary>
        public System.DateTime? NgayHuong { get; set; } // NgayHuong
        public double? PhuCapChucVu { get; set; } // PhuCapChucVu
    
        public int? TDPhoThongID { get; set; } // TDPhoThongID
        public int? TrinhDoID { get; set; } // TrinhDoID
     
        public System.DateTime? NgayVaoDang { get; set; } // NgayVaoDang

        ///<summary>
        /// chưa rõ
        ///</summary>
        public System.DateTime? NgayChinhThuc { get; set; } // NgayChinhThuc

        ///<summary>
        /// Xác định khu vực cán bộ đang công tác.
        ///</summary>
        public string RegionID { get; set; } // RegionID (length: 15)
        public int? DonViID { get; set; } // DonViID

        ///<summary>
        /// Ngày cập nhật thông tin syll lần cuối
        ///</summary>
        public System.DateTime? NgayCapNhat { get; set; } // NgayCapNhat
        public string HinhAnh { get; set; } // HinhAnh (length: 150)

        public int? DanhHieuCaoNhatID { get; set; } // DanhHieuCaoNhatID
     
        public string KhenThuong { get; set; } // KhenThuong
        public string KyLuat { get; set; } // KyLuat (length: 250)
     
        public int? HangThuongBinhID { get; set; } // HangThuongBinhID
        public int? GiaDinhCSID { get; set; } // GiaDinhCSID
        public string CMTND { get; set; } // CMTND (length: 15)

        ///<summary>
        /// là ngày về tổng cục ds nếu cơ quan tuyển dụng ban đầu không phải là tổng cục dân số
        ///</summary>
        public System.DateTime? NgayVe { get; set; } // NgayVe


        ///<summary>
        /// Ngày cấp chứng minh thư
        ///</summary>
        public System.DateTime? NgayCapCMT { get; set; } // NgayCapCMT
        public string NoiCapCMT { get; set; } // NoiCapCMT (length: 300)



        public string LichSuBanThan { get; set; } // LichSuBanThan (length: 2000)
        public string NhanXetDanhGia { get; set; } // NhanXetDanhGia (length: 200)

        ///<summary>
        /// 0. Đang công tác
        /// ; 1. Nghỉ hưu
        /// ; 2. Thôi việc; 
        /// 3. Điều chuyển;
        /// 4.Đang công tác.Đã có thông báo nghỉ hưu
        ///</summary>
        public int? TrangThai { get; set; } // TrangThai

        ///<summary>
        /// 0 Khác; 1. Công chức; 2. Viên chức;3 Hop Dong
        ///</summary>
        public int? KieuCanBo { get; set; } // KieuCanBo

        ///<summary>
        /// Ngày thông báo hoặc dự kiến ngày thông báo
        ///</summary>
        public System.DateTime? NgayThongBaoNghiHuu { get; set; } // NgayThongBaoNghiHuu
        public System.DateTime? NgayNghiHuu { get; set; } // NgayNghiHuu
       
        public string GhiChu { get; set; } // GhiChu (length: 250)
        
        public System.DateTime? NgayGiuNgach { get; set; } // NgayGiuNgach
        public System.DateTime? NgayThoiViec { get; set; } // NgayThoiViec
        public System.DateTime? NgayChuyenCtac { get; set; } // NgayChuyenCtac
        public System.DateTime? NgayTuTran { get; set; } // NgayTuTran
        public int? DonviOldID { get; set; } // DonviOldID
        public string Email { get; set; } // Email (length: 250)
        public string DienThoai { get; set; } // DienThoai (length: 15)
        public System.DateTime? NgayHetHanHD { get; set; } // NgayHetHanHD
        public bool? IsDeleted { get; set; } // IsDeleted


        // Reverse navigation

        /// <summary>
        /// Child DienBienChucVu where [DienBienChucVu].[CanBoID] point to this entity (FK_DienBienChucVu_CanBo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DienBienChucVu> DienBienChucVu { get; set; } // DienBienChucVu.FK_DienBienChucVu_CanBo
        /// <summary>
        /// Child DienBienNgachBac where [DienBienNgachBac].[CanBoID] point to this entity (FK_DienBienLuong_CanBo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DienBienNgachBac> DienBienNgachBac { get; set; } // DienBienNgachBac.FK_DienBienLuong_CanBo
        /// <summary>
        /// Child LyLuanChinhTri_CB where [LyLuanChinhTri_CB].[CanBoID] point to this entity (FK_LyLuanChinhTri_CB_CanBo)
        /// </summary>
     
        public virtual System.Collections.Generic.ICollection<QTCongTac> QTCongTac { get; set; } // QTCongTac.FK_QuaTrinhCongTac_CanBo
        /// <summary>
        /// Child QTKyLuat where [QTKyLuat].[CanBoID] point to this entity (FK_QTKyLuat_CanBo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<QTKyLuat> QTKyLuat { get; set; } // QTKyLuat.FK_QTKyLuat_CanBo
        /// <summary>
        /// Child QuanHeGiaDinh where [QuanHeGiaDinh].[CanBoID] point to this entity (FK_QuanHeGiaDinh_CanBo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<QuanHeGiaDinh> QuanHeGiaDinh { get; set; } // QuanHeGiaDinh.FK_QuanHeGiaDinh_CanBo
        
        // Foreign keys

        /// <summary>
        /// Parent dmDanToc pointed by [CanBo].([DanTocID]) (FK_CanBo_DanToc)
        /// </summary>
        public virtual dmDanToc dmDanToc { get; set; } // FK_CanBo_DanToc

        /// <summary>
        /// Parent dmDonVi pointed by [CanBo].([DonViID]) (FK_CanBo_dmDonVi)
        /// </summary>
        public virtual dmDonVi dmDonVi { get; set; } // FK_CanBo_dmDonVi

        /// <summary>
        /// Parent dmGiaDinhCS pointed by [CanBo].([GiaDinhCSID]) (FK_CanBo_dmGiaDinhCS)
        /// </summary>
        public virtual dmGiaDinhCS dmGiaDinhCS { get; set; } // FK_CanBo_dmGiaDinhCS

        /// <summary>
        /// Parent dmHangThuongBinh pointed by [CanBo].([HangThuongBinhID]) (FK_CanBo_dmHangThuongBinh)
        /// </summary>
        public virtual dmHangThuongBinh dmHangThuongBinh { get; set; } // FK_CanBo_dmHangThuongBinh

        /// <summary>
        /// Parent dmNgheNghiep pointed by [CanBo].([NgheNghiepID]) (FK_CanBo_NgheNghiep)
        /// </summary>
        public virtual dmNgheNghiep dmNgheNghiep { get; set; } // FK_CanBo_NgheNghiep


        /// <summary>
        /// Parent dmTonGiao pointed by [CanBo].([TonGiaoID]) (FK_CanBo_dmTonGiao)
        /// </summary>
        public virtual dmTonGiao dmTonGiao { get; set; } // FK_CanBo_dmTonGiao

        /// <summary>
        /// Parent dmTrinhDoPT pointed by [CanBo].([TDPhoThongID]) (FK_CanBo_TrinhDoPhoThong)
        /// </summary>
        public virtual dmTrinhDoPT dmTrinhDoPT { get; set; } // FK_CanBo_TrinhDoPhoThong

        public CanBo()
        {
            NgayCapNhat = System.DateTime.Now;
            IsDeleted = false;
            DienBienChucVu = new System.Collections.Generic.List<DienBienChucVu>();
            DienBienNgachBac = new System.Collections.Generic.List<DienBienNgachBac>();
            QTCongTac = new System.Collections.Generic.List<QTCongTac>();
            QTKyLuat = new System.Collections.Generic.List<QTKyLuat>();
            QuanHeGiaDinh = new System.Collections.Generic.List<QuanHeGiaDinh>();
            
        }
    }
}

