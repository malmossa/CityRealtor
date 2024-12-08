using CityRealtor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityRealtor.Pages
{
    public class IndexModel : PageModel
    {
        public List<Home> Homes{ get; private set; }
        public void OnGet()
        {
            Homes = new List<Home>
            {
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120},
                new Home { Price = 300000, Address = "123 Main St", Area = 120}
            };
        }
    }
}
