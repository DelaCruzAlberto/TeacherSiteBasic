using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TeacherSiteInicio.Pages
{
    public class ContactoModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ContactoModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
