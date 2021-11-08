using System.Collections.Generic;
using MP_OnlineStore.Core.Entities;

namespace MP_OnlineStore.WEB.ViewModels
{
    public class ProductsListViewModel
    {
        public CategoryViewModel Category { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
        public int MaxProductsOnPage { get; set; }
    }
}
