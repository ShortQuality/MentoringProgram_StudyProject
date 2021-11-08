using System.Collections.Generic;

namespace MP_OnlineStore.WEB.ViewModels
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
