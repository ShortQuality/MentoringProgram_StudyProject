using System.Collections.Generic;
using MP_OnlineStore.Core.Entities;

namespace MP_OnlineStore.WEB.ViewModels
{
    public class ProductsListViewModel
    {
        public string CategoryName { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public int MaxProductsOnPage { get; set; }
    }
}
