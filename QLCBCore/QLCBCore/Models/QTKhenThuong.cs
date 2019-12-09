using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QTKhenThuong
    {
        public int ID { get; set; } // ID (Primary key)
        public int? CanBoID { get; set; } // CanBoID
        public byte? HinhThucKhenThuongID { get; set; } // HinhThucKhenThuongID
        public string NoiDung { get; set; } // NoiDung (length: 250)
        public string NgayKhenThuong { get; set; } // NgayKhenThuong (length: 10)
        public bool? IsCaoNhat { get; set; } // IsCaoNhat
        public string SoQuyetDinh { get; set; } // SoQuyetDinh (length: 50)
        public System.DateTime? NgayKy { get; set; } // NgayKy
        public string CoQuanBanHanhQD { get; set; } // CoQuanBanHanhQD (length: 250)
        public bool? IsKhenThuong { get; set; } // IsKhenThuong
        public int? MucKhenThuong { get; set; } // MucKhenThuong
        public bool? IsDeleted { get; set; } // IsDeleted

        // Foreign keys

        /// <summary>
        /// Parent dmHinhThucKhenThuong pointed by [QTKhenThuong].([HinhThucKhenThuongID]) (FK_QTKhenThuong_dmHinhThucKhenThuong)
        /// </summary>
        public virtual dmHinhThucKhenThuong dmHinhThucKhenThuong { get; set; } // FK_QTKhenThuong_dmHinhThucKhenThuong

        public QTKhenThuong()
        {
            IsKhenThuong = false;
            IsDeleted = false;
        }
    }
}
