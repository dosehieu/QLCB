using Microsoft.AspNetCore.Mvc.Rendering;
using QLCBCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCBCore.ViewModels
{
    public class CreateCanBoVM
    {
        public List<SelectListItem> LstDanToc { get; set; }
        public List<SelectListItem> LstTonGiao { get; set; }
        public CanBo CanBo { get; set; }
    }
}
