using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP_OnlineStore.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<ProductViewModel> Products { get; set; }
    }
}
