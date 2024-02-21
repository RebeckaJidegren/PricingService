namespace Core
{
    public class Customer
    {
        public required string Id { get; set; }
        public required List<PricingInfo> PricingInfos { get; set; }
        public int FreeDays { get; set; }
    }
}
