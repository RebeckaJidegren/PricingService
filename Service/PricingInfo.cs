namespace Core
{
    public class PricingInfo
    {
        public required string CustomerId { get; set; }
        public required string ServiceName { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; internal set; }
    }
}
