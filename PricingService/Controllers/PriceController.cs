// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QueensLab.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Service;

    [Route("api/[controller]")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        [HttpGet("{customerId}/{startDate}/{endDate}")]
        public string Get(int customerId, DateTime startDate, DateTime endDate)
        {
            // TODO: Kan man ta reda på vilken service som anropar detta WebAPI?  Authtokens? 
            // Men det säger ju fortfarande inget om vilken info den specifika kunden har, det måste ju hämtas från en annan service

            return PricingCalculator.CalculateTotalPrice(customerId, startDate, endDate);
        }
    }
}
