using System.Collections.Generic;

#nullable disable

namespace MP_OnlineStore.Core.Entities
{
    public class CustomerDemographic
    {
        public CustomerDemographic()
        {
            CustomerCustomerDemos = new HashSet<CustomerCustomerDemo>();
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }

        public ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
