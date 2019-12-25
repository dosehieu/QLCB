using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class DienBienChucVu
    {
        public int ID { get; set; } // ID (Primary key)
        public int? CanBoID { get; set; } // CanBoID
        public System.DateTime? TuNgay { get; set; } // TuNgay
        public System.DateTime? DenNgay { get; set; } // DenNgay
        public int? ChucVuID { get; set; } // ChucVuID
        public float? PhuCapChucVu { get; set; } // PhuCapChucVu
        public bool? Curent { get; set; } // Curent
        public bool? isLeader { get; set; } // isLeader
        public System.DateTime? NgayBoNhiem { get; set; } // NgayBoNhiem
        public string SoQuyetDinh { get; set; } // SoQuyetDinh (length: 250)
        public string NguoiKy { get; set; } // NguoiKy (length: 255)
        public int? PhongBanID { get; set; } // PhongBanID
        public bool? IsDangDoan { get; set; } // IsDangDoan
        public bool? IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent CanBo pointed by [DienBienChucVu].([CanBoID]) (FK_DienBienChucVu_CanBo)
        /// </summary>
        public virtual CanBo CanBo { get; set; } // FK_DienBienChucVu_CanBo

        /// <summary>
        /// Parent dmChucVu pointed by [DienBienChucVu].([ChucVuID]) (FK_DienBienChucVu_dmChucVu)
        /// </summary>
        public virtual dmChucVu dmChucVu { get; set; } // FK_DienBienChucVu_dmChucVu

        public DienBienChucVu()
        {
            IsDeleted = false;
        }
    }
}
