using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityRealtor.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = string.Empty;
        public void OnGet()
        {
            Message = "Hello from the backend";
        }
    }
}
