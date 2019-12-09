using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmChucVu
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenChucVu { get; set; } // TenChucVu (length: 100)
        public int? STT { get; set; } // STT
        public decimal? HeSoPhuCap { get; set; } // HeSoPhuCap
        public string TenVietTat { get; set; } // TenVietTat (length: 30)
        public byte? iKieu { get; set; } // iKieu
        public byte? iTruongPho { get; set; } // iTruongPho
        public string MaChucVu { get; set; } // MaChucVu (length: 50)
        public bool? IsDangDoan { get; set; } // IsDangDoan
        public bool? IsDeleted { get; set; } // IsDeleted
        // Reverse navigation

        /// <summary>
        /// Child DienBienChucVu where [DienBienChucVu].[ChucVuID] point to this entity (FK_DienBienChucVu_dmChucVu)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DienBienChucVu> DienBienChucVu { get; set; } // DienBienChucVu.FK_DienBienChucVu_dmChucVu

        public dmChucVu()
        {
            IsDeleted = false;

            DienBienChucVu = new System.Collections.Generic.List<DienBienChucVu>();
        }
    }
}
