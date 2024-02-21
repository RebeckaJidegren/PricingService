namespace Service
{
    using Core;

    public class PricingCalculator
    {
        public static decimal CalculateTotalPrice(Customer customer, DateTime startDate, DateTime endDate)
        {
            decimal totalPrice = 0;

            foreach (var pricingInfo in customer.PricingInfos)
            {
                if (pricingInfo.StartDate <= startDate && endDate <= pricingInfo.EndDate)
                {
                    decimal price = pricingInfo.Price;
                    if (pricingInfo.Discount is not null && pricingInfo.Discount > 0 && pricingInfo.StartDate <= startDate && startDate <= pricingInfo.EndDate)
                    {
                        price -= price * (decimal)pricingInfo.Discount;
                    }

                    totalPrice += price;
                }
            }

            return totalPrice;
        }
    }
}
