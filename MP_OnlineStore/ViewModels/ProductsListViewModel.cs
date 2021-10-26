using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MP_OnlineStore.DAL.Entities;

namespace MP_OnlineStore.ViewModels
{
    public class ProductsListViewModel
    {
        public List<Product> Products { get; set; }
        public Category Category { get; set; }
    }
}
