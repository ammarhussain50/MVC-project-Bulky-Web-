using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        // for this in project file

        // 	<ItemGroup>
        // <FrameworkReference Include = "Microsoft.AspNetCore.App" />

        // </ ItemGroup >
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
