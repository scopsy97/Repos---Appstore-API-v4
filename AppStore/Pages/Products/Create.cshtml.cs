using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppStoreBOL;
using AppStoreBLL;
using Microsoft.Extensions.Configuration;
using AppStoreDAL;


namespace AppStore.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public CreateModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [BindProperty]
        public Product product { get; set; }
        int test = 1;
        public ActionResult OnPost()
        {
            ProductBLL objproduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));

            objproduct.CreateProduct(product);

            return RedirectToPage("./Index");
        }
    }
}
