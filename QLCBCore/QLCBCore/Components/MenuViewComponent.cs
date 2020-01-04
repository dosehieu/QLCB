using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QLCBCore.Components
{
    [ViewComponent(Name = "Menu")]
    public class MenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<string> categories = new List<string>() {
                "Category 1", "Category 2", "Category 3", "Category 4", "Category 5"
            };
            return View("Index");
        }
    }
}
