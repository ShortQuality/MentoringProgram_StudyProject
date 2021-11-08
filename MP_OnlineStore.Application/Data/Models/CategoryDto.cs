using System.Collections.Generic;

namespace MP_OnlineStore.Application.Data.Models
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public ICollection<ProductDto> Products { get; set; }
    }
}
