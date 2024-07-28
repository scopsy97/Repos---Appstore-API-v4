using AppStoreBLL;
using AppStoreBOL;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppStoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: api/<ProductController>
        [HttpGet]
        

        public IEnumerable<Product> GetProducts()
        {
            ProductBLL objproduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));
           // var products = 

            return objproduct.GetProductsWFApi(); ;

        }

        

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
      public Product GetProduct(int id)
        {
            ProductBLL objproduct = new ProductBLL(_configuration.GetConnectionString("DefaultConnection"));
            Product products = objproduct.GetProduct(id);

            return products;

        }

      
        
    }
}
