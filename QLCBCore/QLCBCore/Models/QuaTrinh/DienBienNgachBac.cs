using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class DienBienNgachBac
    {
        public int ID { get; set; } // ID (Primary key)
        public int? CanBoID { get; set; } // CanBoID
        public int? NgachID { get; set; } // NgachID
        public int? BacLuong { get; set; } // BacLuong
        public System.DateTime? NgayHuong { get; set; } // NgayHuong
        public System.DateTime? NgayKetThuc { get; set; } // NgayKetThuc

        ///<summary>
        /// (Năm)
        ///</summary>
        public int? ThoiHanNangBac { get; set; } // ThoiHanNangBac
        public bool? DaVuotKhung { get; set; } // DaVuotKhung
        public string SoQD { get; set; } // SoQD (length: 50)
        public string NguoiKy { get; set; } // NguoiKy (length: 100)
        public System.DateTime? NgayKy { get; set; } // NgayKy

        ///<summary>
        /// Hệ số phụ cấp bảo lưu. cán bộ chuyển đến từ nơi khác, có hệ số phụ cấp cao hơn thì bảo lưu hệ số phụ cấp đó
        ///</summary>
        public double? HSCLBL { get; set; } // HSCLBL

        ///<summary>
        /// True: Đã vượt khung và hưởng thâm niên vượt khung
        /// False: Chưa vượt khung
        ///</summary>
        public float? HeSo { get; set; } // HeSo

        ///<summary>
        /// True: Đã vượt khung và hưởng thâm niên vượt khung
        /// False: Chưa vượt khung
        ///</summary>
        public decimal? PhuCapVuotKhung { get; set; } // PhuCapVuotKhung
        public decimal? PhuCapKhac { get; set; } // PhuCapKhac
        public decimal? LuongCoBan { get; set; } // LuongCoBan

        ///<summary>
        /// 1: Nâng bậc thường xuyên
        /// 2: Nâng bậc do thành tích xuất sắc
        /// 3: có thông báo nghỉ hưu và được nâng trước thời hạn
        /// 4: thi nâng ngạch
        ///</summary>
        public int? Kieu { get; set; } // Kieu

        ///<summary>
        /// =1 và kieu=4 nâng ngạch hiện tại
        /// =1 và &lt;4 nâng bậc hiện tại
        ///</summary>
        public bool? Curent { get; set; } // Curent
        public int? NgachCuID { get; set; } // NgachCuID
        public decimal? PhuCapChucVu { get; set; } // PhuCapChucVu
        public decimal? PhuCapTrachNhiem { get; set; } // PhuCapTrachNhiem
        public decimal? PhuCapKhuVuc { get; set; } // PhuCapKhuVuc
        public bool? BatDauGiuNgach { get; set; } // BatDauGiuNgach
        public string GhiChu { get; set; } // GhiChu (length: 350)
        public bool? isTapSu { get; set; } // isTapSu
        public decimal? PhuCapUuDai { get; set; } // PhuCapUuDai
        public decimal? DonGiaDocHai { get; set; } // DonGiaDocHai
        public decimal? PhuCapDocHai { get; set; } // PhuCapDocHai
        public System.DateTime? NgayBatDauGiuNgach { get; set; } // NgayBatDauGiuNgach
        public int? ThoiGianTapSu { get; set; } // ThoiGianTapSu
        public decimal? PhuCapThuHut { get; set; } // PhuCapThuHut
        public decimal? PhuCapLuuDong { get; set; } // PhuCapLuuDong
        public decimal? HeSoChenhLechBaoLuu { get; set; } // HeSoChenhLechBaoLuu
        public decimal? PhuCapDacBiet { get; set; } // PhuCapDacBiet
        public decimal? PhuCapThamNien { get; set; } // PhuCapThamNien
        public double? ThamNienVungKhoKhan { get; set; } // ThamNienVungKhoKhan
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
