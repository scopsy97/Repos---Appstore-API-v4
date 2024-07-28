using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AppStoreBOL;
using AppStoreBLL;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace AppStore.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

       // public List<Product> Products { get; set; }

        //1
        public PaginatedList<Product> Products { get; set;}



        //search
        [BindProperty(SupportsGet = true)]
        public string searchString { get; set; }
        public SelectList Categories { get; set; }
        [BindProperty(SupportsGet = true)]
        public string productCategory { get; set; }
        public string CurrentFilter { get; set; }
        

        //Sort
        public string NameSort { get; set; }
        public string CategorySort { get; set; }
        public string PriceSort { get; set; }

        public string CurrentSort { get; set; }


        //2
        public void OnGet(string searchString, string sortOrder, string currentFilter, int? pageIndex)
        {
            ProductBLL objProduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));

            // recherche par catégorie liste deroulante
            IEnumerable<string> categoryQuery = objProduct.GetCategories();
            Categories = new SelectList(categoryQuery.ToList());

            //trier par ordre asc ou desc la catégorie et le nom du produit
            NameSort = String.IsNullOrEmpty(sortOrder) ? "ProductName_desc" : "";
            CategorySort = sortOrder == "CategoryName_asc" ? "CategoryName_desc" : "CategoryName_asc";


            //avant la pagnination
            //searchString recherche
           // Products = objProduct.GetProduct(searchString, productCategory, sortOrder).ToList();

            if (searchString != null) { pageIndex = 1; } else { searchString = currentFilter; }
            int pageSize = 10;
            // 3 pagination
            Products = new PaginatedList<Product>(objProduct.GetProduct(searchString, productCategory, sortOrder).ToList(), pageIndex ?? 1, pageSize);





            // avant la recherche
            //Products = objProduct.GetProduct().ToList();
            int test = 1;
          
        }
    }
}
