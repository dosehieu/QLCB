using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class QuanHeGiaDinh
    {
        public int ID { get; set; } // ID (Primary key)
        public int? CanBoID { get; set; } // CanBoID
        public int? QuanHeGDID { get; set; } // QuanHeGDID
        public string HoTen { get; set; } // HoTen (length: 150)
        public string NamSinh { get; set; } // NamSinh (length: 10)
        public string NgheNghiep { get; set; } // NgheNghiep (length: 150)
        public string GhiChu { get; set; } // GhiChu (length: 500)
        public string ThongTinKhac { get; set; } // ThongTinKhac (length: 100)
        public string ThongTinTCXH { get; set; } // ThongTinTCXH (length: 100)
        public string QueQuan { get; set; } // QueQuan (length: 100)

        ///<summary>
        /// 0:Nội;1:Ngoại
        ///</summary>
        public int? Type { get; set; } // Type
        public bool? IsDeleted { get; set; } // IsDeleted
        public string ChucVu { get; set; } // ChucVu (length: 200)
        public string CoQuan { get; set; } // CoQuan (length: 200)
        public string HoKhau { get; set; } // HoKhau (length: 200)
        public string DiaChi { get; set; } // DiaChi (length: 200)

        // Foreign keys

        /// <summary>
        /// Parent CanBo pointed by [QuanHeGiaDinh].([CanBoID]) (FK_QuanHeGiaDinh_CanBo)
        /// </summary>
        public virtual CanBo CanBo { get; set; } // FK_QuanHeGiaDinh_CanBo

        /// <summary>
        /// Parent dmQuanHeGiaDinh pointed by [QuanHeGiaDinh].([QuanHeGDID]) (FK_QuanHeGiaDinh_dmQuanHeGiaDinh)
        /// </summary>
        public virtual dmQuanHeGiaDinh dmQuanHeGiaDinh { get; set; } // FK_QuanHeGiaDinh_dmQuanHeGiaDinh

        public QuanHeGiaDinh()
        {
            IsDeleted = false;
        }
    }
}
