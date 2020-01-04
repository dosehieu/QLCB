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
        [Display(Name = "Mã")]
        public string Ma { get; set; } // Ma (length: 50)

       
        //[Display(Name = "Số hiệu")]
        //[MaxLength(50)]
        //[Column("SOHIEU", TypeName = "nvarchar")]
        [Display(Name = "Số hiệu")]
        public string SoHieu { get; set; } // SoHieu (length: 50)
        [Required(AllowEmptyStrings = false, ErrorMessage = "Trường này không được để trống")]
        [Display(Name = "Họ tên")]
        [MaxLength(100)]
        public string HoTen { get; set; } // HoTen (length: 100)
        [Display(Name = "Tên gọi khác")]
        public string TenGoiKhac { get; set; } // TenGoiKhac (length: 100)
        [Display(Name = "Giới tính")]
        public bool? GioiTinh { get; set; } // GioiTinh
        [Required(AllowEmptyStrings = false, ErrorMessage = "Trường này không được để trống")]
        [Display(Name = "Ngày sinh")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(TypeName = "Date")]
        public System.DateTime? NgaySinh { get; set; } // NgaySinh
        [Display(Name = "Dân tộc")]
        [ForeignKey("dmDanToc")]
        public int? DanTocID { get; set; } // DanTocID
        [Display(Name = "Tôn giáo")]
        [ForeignKey("dmTonGiao")]
        public int? TonGiaoID { get; set; } // TonGiaoID
        [Display(Name = "Đơn vị")]
        [ForeignKey("dmDonVi")]
        public int? DonViID { get; set; } // DonViID

        ///<summary>
        /// 0. Đang công tác
        /// ; 1. Nghỉ hưu
        /// ; 2. Thôi việc; 
        /// 3. Điều chuyển;
        /// 4.Đang công tác.Đã có thông báo nghỉ hưu
        ///</summary>
        [Display(Name = "Trạng thái công tác")]
        public int? TrangThai { get; set; } // TrangThai
        [Display(Name = "Điện thoại")]
        [MaxLength(15)]
        public string DienThoai { get; set; } // DienThoai (length: 15)
        [Display(Name = "Email")]
        [MaxLength(250)]
        public string Email { get; set; } // Email (length: 250)
        [Display(Name = "CMTND")]
        [MaxLength(15)]
        public string CMTND { get; set; } // CMTND (length: 15)
        ///<summary>
        /// Ngày cấp chứng minh thư
        ///</summary>
        [Display(Name = "Ngày cấp")]
        public System.DateTime? NgayCapCMT { get; set; } // NgayCapCMT
        [Display(Name = "Nơi cấp")]
        [MaxLength(300)]
        public string NoiCapCMT { get; set; } // NoiCapCMT (length: 300)
        [Display(Name = "Nơi sinh")]
        [MaxLength(500)]
        public string NoiSinhID { get; set; } // NoiSinhID (length: 500)
        [Display(Name = "Quê quán")]
        [MaxLength(500)]

        public string QueQuanID { get; set; } // QueQuanID (length: 500)

        [Display(Name = "Nơi đăng kí HKTT")]
        [MaxLength(300)]
        public string HKTT { get; set; } // HKTT (length: 300)
        
        [Display(Name = "Nơi ở hiện nay")]
        [MaxLength(300)]
        public string NoiO { get; set; } // NoiO (length: 300)
        [Display(Name = "Trình độ phổ thông")]
        [ForeignKey("dmTrinhDoPT")]
        public int? TDPhoThongID { get; set; } // TDPhoThongID
        [ForeignKey("dmHocHam")]
        [Display(Name = "Học hàm")]
        
        public int? HocHamID { get; set; } // ChucDanhKhoaHocID
        [Display(Name = "Ảnh đại diện")]
        [MaxLength(150)]
        public string HinhAnh { get; set; } // HinhAnh (length: 150)
        //THÔNG TIN TUYỂN DỤNG
        [Display(Name = "Nghề nghiệp")]
        [ForeignKey("dmNgheNghiep")]
        public int? NgheNghiepID { get; set; } // NgheNghiepID
        [Display(Name = "Cơ quan tuyển dụng")]
        [MaxLength(100)]
        public string CoquanTuyenDung { get; set; } // 100
        [Required(AllowEmptyStrings = false, ErrorMessage = "Trường này không được để trống")]
        [Display(Name = "Ngày tuyển ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(TypeName = "Date")]
        public System.DateTime? NgayTuyen { get; set; } // NgayTuTran
        [Required(AllowEmptyStrings = false, ErrorMessage = "Trường này không được để trống")]
        [Display(Name = "Ngày về CQ")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(TypeName = "Date")]
        public System.DateTime? NgayVeCQ { get; set; } // NgayTuTran
        
        [Display(Name = "Hình thức thi tuyển")]
        public int? HinhThucThiTuyenID { get; set; } // HinhThucThiTuyen
        ///<summary>
        /// 0 Khác; 1. Công chức; 2. Viên chức;3 Hop Dong
        ///</summary>
        
        [Display(Name = "Phân loại cán bộ")]
        [ForeignKey("dmKieuCanBo")]
        public int? KieuCanBo { get; set; } // KieuCanBo
        [Display(Name = "Ngày hết hạn hợp đồng")]
        public System.DateTime? NgayHetHanHD { get; set; } // NgayHetHanHD
        [Display(Name = "CV được giao")]
        
        public string CongViecDuocGiao { get; set; } // CongViecChinh
        [Display(Name = "Sở trường công tác")]
        public string SoTruongCongTac { get; set; } // CongViecChinh

        //THAM GIA TỔ CHỨC XÃ HỘI
        [Display(Name = "Ngày vào đảng")]
        public System.DateTime? NgayVaoDang { get; set; } // NgayVaoDang
        [Display(Name = "Ngày chính thức")]
        public System.DateTime? NgayChinhThuc { get; set; } // NgayChinhThuc
        [Display(Name = "Ngày nhập ngũ")]
        public System.DateTime? NgayNhapNgu { get; set; } // NgayNghiHuu
        [Display(Name = "Ngày xuất ngũ")]
        public System.DateTime? NgayXuatNgu { get; set; } // NgayNghiHuu
        [Display(Name = "Quân hàm cao nhất")]
        [ForeignKey("dmQuanHam")]
        public int? QuanHamCaoNhatID { get; set; } // QuanHamCaoNhatID
        [Display(Name = "Thương binh hạng")]
        [ForeignKey("dmHangThuongBinh")]
        public int? HangThuongBinhID { get; set; } // HangThuongBinhID
        [Display(Name = "Gia đình chính sách")]
        [ForeignKey("dmGiaDinhCS")]
        public int? GiaDinhCSID { get; set; } // GiaDinhCSID

        //THÔNG TIN KHÁC
        [Display(Name = "Tình trạng sức khỏe")]
        [ForeignKey("dmSucKhoe")]
        public int? SucKhoeID { get; set; } // SucKhoeID
        [Display(Name = "Chiều cao(cm)")]
        public int? ChieuCao { get; set; } // ChieuCao
        [Display(Name = "Cân nặng(Kg)")]
        public int? CanNang { get; set; } // CanNang
        [Display(Name = "Nhóm máu")]
        [ForeignKey("dmNhomMau")]
        public int? NhomMauID { get; set; } // NhomMauID
        [Display(Name = "Số sổ BHXH")]
        [MaxLength(30)]
        public string SoBHXH { get; set; } // SoBHXH (length: 30)
        [Display(Name = "Nơi cấp sổ BHXH")]
        [MaxLength(250)]
        public string NoiCapSoBHXH { get; set; } // NoiCapSoBHXH (length: 250)
        [Display(Name = "Số BHYT")]
        [MaxLength(30)]
        public string SoBHYT { get; set; } // SoBHYT (length: 30)
        [Display(Name = "Lịch sử bản thân")]
        [MaxLength(2000)]
        public string LichSuBanThan { get; set; } // LichSuBanThan (length: 2000)
        [Display(Name = "Ghi chú")]
        [MaxLength(250)]
        public string GhiChu { get; set; } // GhiChu (length: 250)
        [Display(Name = "Nhận xét đánh giá")]
        [MaxLength(500)]
        public string NhanXetDanhGia { get; set; } // NhanXetDanhGia (length: 500)
        [ForeignKey("dmChucVu")]
        [Display(Name = "Chức vụ")]
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
        public double? PhuCapKhac { get; set; } // PhuCapKhac
        [ForeignKey("dmTrinhDo")]
        [Display(Name = "Trình độ")]
        public int? TrinhDoID { get; set; } // TrinhDoID
        ///<summary>
        /// Xác định khu vực cán bộ đang công tác.
        ///</summary>
        public string RegionID { get; set; } // RegionID (length: 15)
        ///<summary>
        /// Ngày cập nhật thông tin syll lần cuối
        ///</summary>
        public System.DateTime? NgayCapNhat { get; set; } // NgayCapNhat
        public int? DanhHieuCaoNhatID { get; set; } // DanhHieuCaoNhatID
        public string KhenThuong { get; set; } // KhenThuong
        public string KyLuat { get; set; } // KyLuat (length: 250)
        ///<summary>
        /// là ngày về tổng cục ds nếu cơ quan tuyển dụng ban đầu không phải là tổng cục dân số
        ///</summary>
        public System.DateTime? NgayVe { get; set; } // NgayVe
        ///<summary>
        /// Ngày thông báo hoặc dự kiến ngày thông báo
        ///</summary>
        public System.DateTime? NgayThongBaoNghiHuu { get; set; } // NgayThongBaoNghiHuu
        public System.DateTime? NgayNghiHuu { get; set; } // NgayNghiHuu
        public System.DateTime? NgayGiuNgach { get; set; } // NgayGiuNgach
        public System.DateTime? NgayThoiViec { get; set; } // NgayThoiViec
        public System.DateTime? NgayChuyenCtac { get; set; } // NgayChuyenCtac
        public System.DateTime? NgayTuTran { get; set; } // NgayTuTran
        public int? DonviOldID { get; set; } // DonviOldID
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
        /// <summary>
        /// Parent dmNhomMau pointed by [CanBo].([NhomMauID]) (FK_CanBo_NhomMau)
        /// </summary>
        public virtual dmNhomMau dmNhomMau { get; set; } // FK_CanBo_NhomMau
        public virtual System.Collections.Generic.ICollection<QTCongTac> QTCongTac { get; set; } // QTCongTac.FK_QuaTrinhCongTac_CanBo
        /// <summary>
        /// Child QTKyLuat where [QTKyLuat].[CanBoID] point to this entity (FK_QTKyLuat_CanBo)
        /// </summary>

        public virtual System.Collections.Generic.ICollection<QTKhenThuong> QTKhenThuong { get; set; } // 

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
        public virtual dmHocHam dmHocHam { get; set; } // FK_CanBo_ChucDanhKhoaHoc
        

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
        /// Parent dmQuanHam pointed by [CanBo].([QuanHamCaoNhatID]) (FK_CanBo_QuanHam)
        /// </summary>
        public virtual dmQuanHam dmQuanHam { get; set; } // FK_CanBo_QuanHam

        /// <summary>
        /// Parent dmTonGiao pointed by [CanBo].([TonGiaoID]) (FK_CanBo_dmTonGiao)
        /// </summary>
        public virtual dmTonGiao dmTonGiao { get; set; } // FK_CanBo_dmTonGiao

        /// <summary>
        /// Parent dmTrinhDoPT pointed by [CanBo].([TDPhoThongID]) (FK_CanBo_TrinhDoPhoThong)
        /// </summary>
        public virtual dmTrinhDoPT dmTrinhDoPT { get; set; } // FK_CanBo_TrinhDoPhoThong
        public virtual dmChucVu dmChucVu { get; set; } // FK_CanBo_TrinhDoPhoThong
        public virtual dmKieuCanBo dmKieuCanBo { get; set; } // FK_CanBo_TrinhDoPhoThong
        public virtual dmTrinhDo dmTrinhDo { get; set; } // FK_CanBo_TrinhDoPhoThong

        public CanBo()
        {
            NgayCapNhat = System.DateTime.Now;
            IsDeleted = false;
            DienBienChucVu = new System.Collections.Generic.List<DienBienChucVu>();
            DienBienNgachBac = new System.Collections.Generic.List<DienBienNgachBac>();
            QTCongTac = new System.Collections.Generic.List<QTCongTac>();
            QTKyLuat = new System.Collections.Generic.List<QTKyLuat>();
            QuanHeGiaDinh = new System.Collections.Generic.List<QuanHeGiaDinh>();
            QTKhenThuong = new System.Collections.Generic.List<QTKhenThuong>();
        }
    }
}

