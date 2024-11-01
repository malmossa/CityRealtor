using CityRealtor.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CityRealtor.Models;

namespace CityRealtor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly HomeService _homeService;
        public List<Home> Homes { get; private set; }
        public decimal ThresholdPrice { get; set; }

        public IndexModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        public void OnGet()
        {
           Homes = _homeService.GetHomes();

           ThresholdPrice = 400000;
        }
    }
}
