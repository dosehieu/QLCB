﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.Models
{
    public class dmNgheNghiep
    {
        public int ID { get; set; } // ID (Primary key)
        public string TenNgheNghiep { get; set; } // TenNgheNghiep (length: 150)
        public int? STT { get; set; } // STT
        public string MaNgheNghiep { get; set; } // MaNgheNghiep (length: 50)
        public bool? IsDeleted { get; set; } // IsDeleted


        // Reverse navigation

        /// <summary>
        /// Child CanBo where [CanBo].[NgheNghiepID] point to this entity (FK_CanBo_NgheNghiep)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CanBo> CanBo { get; set; } // CanBo.FK_CanBo_NgheNghiep

        public dmNgheNghiep()
        {
            IsDeleted = false;
            CanBo = new System.Collections.Generic.List<CanBo>();
        }
    }
}
