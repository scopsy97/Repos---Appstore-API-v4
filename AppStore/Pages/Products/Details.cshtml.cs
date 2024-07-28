
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

using AppStoreBOL;
using AppStoreBLL;

namespace AppStore.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public DetailsModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [BindProperty]
        public Product product { get; set; }


        public ActionResult OnGet(int id)
        {
            ProductBLL objproduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));

            if (id == null)
            {
                return NotFound();
            }

            product = objproduct.GetProduct(id);

            return Page();

        }

    }
}
