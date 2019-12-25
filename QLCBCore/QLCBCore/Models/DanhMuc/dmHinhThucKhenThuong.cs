using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmHinhThucKhenThuong
    {
        public byte ID { get; set; } // ID (Primary key)
        public string MaHinhThucKhenThuong { get; set; } // MaHinhThucKhenThuong (length: 5)
        public string TenHinhThucKhenThuong { get; set; } // TenHinhThucKhenThuong (length: 100)
        public bool? IsKhenThuong { get; set; } // IsKhenThuong
        public bool? IsDeleted { get; set; } // IsDeleted


        // Reverse navigation

        /// <summary>
        /// Child QTKhenThuong where [QTKhenThuong].[HinhThucKhenThuongID] point to this entity (FK_QTKhenThuong_dmHinhThucKhenThuong)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<QTKhenThuong> QTKhenThuong { get; set; } // QTKhenThuong.FK_QTKhenThuong_dmHinhThucKhenThuong

        public dmHinhThucKhenThuong()
        {
            IsDeleted = false;
            QTKhenThuong = new System.Collections.Generic.List<QTKhenThuong>();
        }
    }
}
