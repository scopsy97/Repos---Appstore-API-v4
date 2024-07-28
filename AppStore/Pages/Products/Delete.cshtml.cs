using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppStoreBLL;
using AppStoreBOL;
using Microsoft.Extensions.WebEncoders.Testing;
using static System.Reflection.Metadata.BlobBuilder;

namespace AppStore.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public DeleteModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Product product { get; set; }

        public ActionResult OnGet(int id)
        {
            ProductBLL objproduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));

            if (id == null)
            {
                return NotFound();
            }


            product = objproduct.GetProduct(id);
            int test = 1;
           return Page();
        }
        public ActionResult OnPost(int id)
        {
            ProductBLL objproduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));

            if (id == null)
            {
                return NotFound();
            }

            objproduct.DeleteProduct(id);

            return RedirectToPage("./Index");
        }



    }
}
