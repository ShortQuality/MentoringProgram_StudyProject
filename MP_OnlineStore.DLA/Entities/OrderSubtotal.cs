#nullable disable

namespace MP_OnlineStore.DAL.Entities
{
    public class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
