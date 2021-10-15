using System;

#nullable disable

namespace MP_OnlineStore.DAL.Entities
{
    public class SummaryOfSalesByYear
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
