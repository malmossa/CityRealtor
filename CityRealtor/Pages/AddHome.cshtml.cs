using CityRealtor.Models;
using CityRealtor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityRealtor.Pages
{
    public class AddHomeModel : PageModel
    {
        private readonly HomeService _homeService;

        public AddHomeModel(HomeService homeService)
        {
            _homeService = homeService;
        }

        [BindProperty]
        public Home NewHome {  get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            _homeService.AddHome(NewHome);
            return RedirectToPage("Index");
        }
    }
}
