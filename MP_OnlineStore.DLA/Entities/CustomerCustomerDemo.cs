#nullable disable

namespace MP_OnlineStore.DAL.Entities
{
    public class CustomerCustomerDemo
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public Customer Customer { get; set; }
        public CustomerDemographic CustomerType { get; set; }
    }
}
