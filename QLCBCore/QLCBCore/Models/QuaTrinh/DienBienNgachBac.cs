using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class DienBienNgachBac
    {
        public int ID { get; set; } // ID (Primary key)

        [ForeignKey("CanBo")]
        [Display(Name = "Mã cán bộ")]
        public int? CanBoID { get; set; } // CanBoID

        [ForeignKey("dmNgach")]
        [Display(Name = "Mã ngach")]
        public int? NgachID { get; set; } // NgachID

        [Display(Name = "Bậc lương")]
        public int? BacLuong { get; set; } // BacLuong

        [Display(Name = "Ngày hưởng")]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? NgayHuong { get; set; } // NgayHuong

        [Display(Name = "Ngày kết thúc")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? NgayKetThuc { get; set; } // NgayKetThuc

        ///<summary>
        /// (Năm)
        ///</summary>
        ///
        [Display(Name = "Thời hạn nâng bậc")]
        public int? ThoiHanNangBac { get; set; } // ThoiHanNangBac


        [Display(Name = "Đã vượt khung")]
        public bool? DaVuotKhung { get; set; } // DaVuotKhung


        [Display(Name = "Số quyết định")]
        public string SoQD { get; set; } // SoQD (length: 50)


        [Display(Name = "Người ký")]
        public string NguoiKy { get; set; } // NguoiKy (length: 100)


        [Display(Name = "Ngày ký")]

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime")]
        public System.DateTime? NgayKy { get; set; } // NgayKy

        ///<summary>
        /// Hệ số phụ cấp bảo lưu. cán bộ chuyển đến từ nơi khác, có hệ số phụ cấp cao hơn thì bảo lưu hệ số phụ cấp đó
        ///</summary>
        ///

        [Display(Name = "Hệ số phụ cấp bảo lưu")]
        public double? HSCLBL { get; set; } // HSCLBL

        ///<summary>
        /// True: Đã vượt khung và hưởng thâm niên vượt khung
        /// False: Chưa vượt khung
        ///</summary>
        ///

        [Display(Name = "Hệ số")]
        public float? HeSo { get; set; } // HeSo

        ///<summary>
        /// True: Đã vượt khung và hưởng thâm niên vượt khung
        /// False: Chưa vượt khung
        ///</summary>
        ///

        [Display(Name = "Phụ cấp vượt khung")]
        public decimal? PhuCapVuotKhung { get; set; } // PhuCapVuotKhung


        [Display(Name = "Phụ cấp khác")]
        public decimal? PhuCapKhac { get; set; } // PhuCapKhac

        [Display(Name = "Lương cơ bản")]
        public decimal? LuongCoBan { get; set; } // LuongCoBan

        ///<summary>
        /// 1: Nâng bậc thường xuyên
        /// 2: Nâng bậc do thành tích xuất sắc
        /// 3: có thông báo nghỉ hưu và được nâng trước thời hạn
        /// 4: thi nâng ngạch
        ///</summary>
        ///

        [Display(Name = "Kiểu")]
        public int? Kieu { get; set; } // Kieu

        ///<summary>
        /// =1 và kieu=4 nâng ngạch hiện tại
        /// =1 và &lt;4 nâng bậc hiện tại
        ///</summary>
        ///

        [Display(Name = "Curent")]
        public bool? Curent { get; set; } // Curent

        //[ForeignKey("dmNgach")]
        [Display(Name = "Mã ngạch cũ")]
        public int? NgachCuID { get; set; } // NgachCuID

        [Display(Name = "Phụ cấp chức vụ")]
        public decimal? PhuCapChucVu { get; set; } // PhuCapChucVu

        [Display(Name = "Phụ cấp trách nhiệm")]
        public decimal? PhuCapTrachNhiem { get; set; } // PhuCapTrachNhiem

        [Display(Name = "Phụ cấp khác")]
        public decimal? PhuCapKhuVuc { get; set; } // PhuCapKhuVuc

        [Display(Name = "Bắt đầu giữ ngạch")]
        public bool? BatDauGiuNgach { get; set; } // BatDauGiuNgach

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; } // GhiChu (length: 350)

        [Display(Name = "is Tập sự")]
        public bool? isTapSu { get; set; } // isTapSu

        [Display(Name = "Phụ cấp ưu đãi")]
        public decimal? PhuCapUuDai { get; set; } // PhuCapUuDai

        [Display(Name = "Đơn giá độc hại")]
        public decimal? DonGiaDocHai { get; set; } // DonGiaDocHai

        [Display(Name = "Phụ cấp độc hại")]
        public decimal? PhuCapDocHai { get; set; } // PhuCapDocHai

        [Display(Name = "Ngày bắt đầu giữ ngạch")]
        public System.DateTime? NgayBatDauGiuNgach { get; set; } // NgayBatDauGiuNgach

        [Display(Name = "Thời gian tập sự")]
        public int? ThoiGianTapSu { get; set; } // ThoiGianTapSu

        [Display(Name = "Phụ cấp thu hút")]
        public decimal? PhuCapThuHut { get; set; } // PhuCapThuHut

        [Display(Name = "Phụ cấp lưu động")]
        public decimal? PhuCapLuuDong { get; set; } // PhuCapLuuDong

        [Display(Name = "Hệ số chênh lệch bảo lưu")]
        public decimal? HeSoChenhLechBaoLuu { get; set; } // HeSoChenhLechBaoLuu

        [Display(Name = "Phụ cấp đặc biệt")]
        public decimal? PhuCapDacBiet { get; set; } // PhuCapDacBiet

        [Display(Name = "Phụ cấp thâm niên")]
        public decimal? PhuCapThamNien { get; set; } // PhuCapThamNien

        [Display(Name = "Thâm niên vùng khó khăn")]
        public double? ThamNienVungKhoKhan { get; set; } // ThamNienVungKhoKhan

        [Display(Name = "IsDeleted")]
        public bool? IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent CanBo pointed by [DienBienNgachBac].([CanBoID]) (FK_DienBienLuong_CanBo)
        /// </summary>
        public virtual CanBo CanBo { get; set; } // FK_DienBienLuong_CanBo

        /// <summary>
        /// Parent dmNgach pointed by [DienBienNgachBac].([NgachID]) (FK_DienBienLuong_Ngach)
        /// </summary>
        public virtual dmNgach dmNgach { get; set; } // FK_DienBienLuong_Ngach

        public DienBienNgachBac()
        {
            DaVuotKhung = false;
            PhuCapVuotKhung = 0m;
            ThamNienVungKhoKhan = 0;
            IsDeleted = false;
        }
    }
}
