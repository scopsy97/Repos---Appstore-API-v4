using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppStoreBOL;
using AppStoreBLL;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace AppStore.Pages.Products
{
    public class EditModel : PageModel
    {

        private readonly IConfiguration _configuration;
        public EditModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [BindProperty]
        public Product product { get; set; }

        public SelectList Categories { get; set; }
    

        public ActionResult OnGet(int id, int monid)
        {
            ProductBLL objproduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));

            IEnumerable<string> categoryQuery = objproduct.GetCategories();
            Categories = new SelectList(categoryQuery.ToList());

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

            objproduct.EditProduct(product); /*AJOUTER productCategory*/

            return RedirectToPage("./Index");
        }
    }
}
