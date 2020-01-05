using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmDonVi
    {
        public int ID { get; set; } // ID (Primary key)
        [Display(Name ="Mã đơn vị")]
        [MaxLength(30)]
        public string MaDonVi { get; set; } // MaDonVi (length: 30)
        [Display(Name = "Tên đơn vị")]
        [MaxLength(150)]
        public string TenDonVi { get; set; } // TenDonVi (length: 150)
        public string RegionID { get; set; } // RegionID (length: 15)
        public int? MaCha { get; set; } // MaCha
        public int? Leve { get; set; } // Leve
        public int? STT { get; set; } // STT
        [Display(Name = "Tên viết tắt")]
        [MaxLength(150)]
        public string TenVietTat { get; set; } // TenVietTat (length: 150)
        public byte? KieuDonvi { get; set; } // KieuDonvi
        public string DonViAllID { get; set; } // DonViAllID

        public bool? IsDeleted { get; set; } // IsDeleted

        // Reverse navigation

        /// <summary>
        /// Child CanBo where [CanBo].[DonViID] point to this entity (FK_CanBo_dmDonVi)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_dmDonVi

        public virtual System.Collections.Generic.ICollection<DienBienChucVu> DienBienChucVu { get; set; }

        public dmDonVi()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();
            DienBienChucVu = new System.Collections.Generic.List<DienBienChucVu>();
        }

    }
}
