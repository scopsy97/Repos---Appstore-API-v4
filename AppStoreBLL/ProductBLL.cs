using AppStoreDAL;
using AppStoreBOL;

namespace AppStoreBLL
{
    public class ProductBLL
    {


        private ProductDB productDB;
        public ProductBLL(string ConnectionString)
        {
            productDB = new ProductDB(ConnectionString);
        }


        public IEnumerable<Product> GetProduct(string SearchString, string Category, string sortOrder)
        {
            return productDB.GetProductDB(SearchString, Category, sortOrder);
        }

        public IEnumerable<String> GetCategories()
        {
            return productDB.GetCategoriesDB();
        }
        
        //connexion au Winform
        public IEnumerable<Product> GetProductWF()
        {

             
            return productDB.GetProductWFDB();

        }


        //connexion wf Api
        public IEnumerable<Product> GetProductsWFApi()
        {
            return productDB.GetProductsDBWFApi();

        }

        



        public void EditProduct(Product product)
        {
            productDB.EditProductDB(product);
        }

        public void CreateProduct(Product product)
        {
            productDB.CreateProductDB(product);
            
        }
        
        public Product GetProduct(int idproduct)
        {
           return productDB.GetProductDB(idproduct);

        }

        public void DeleteProduct(int idproduct)
        {
             productDB.DeleteProductDB(idproduct);

        }
    }
}
