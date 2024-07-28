using System.Data.SqlClient;
/*
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Razor;
*/
using System.Data;
using AppStoreBOL;
using static AppStoreDAL.ProductDB;
using static System.Formats.Asn1.AsnWriter;



namespace AppStoreDAL
{
    public class ProductDB
    {
        private readonly string connectionString;
        public ProductDB(string ConnectionString)
        {
            connectionString = "Data Source=localhost;Initial Catalog=Store;Integrated Security=True;Encrypt=False";
           // connectionString = "Data source=-PC\\SQLEXPRESS;Database=Store;Trusted_Connection=True;";

        }


        /*
       * ********************************************************
       * Création d'un produit de la page Products/create
       * ********************************************************
       * */

        public void CreateProductDB(Product product)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("USP_InsertProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ProductName", product.ProductName));
                    cmd.Parameters.Add(new SqlParameter("@ProductPrice", product.ProductPrice));
                    cmd.Parameters.Add(new SqlParameter("@ProductReference", product.ProductReference));
                    cmd.Parameters.Add(new SqlParameter("@ProductDescription", product.ProductDescription));
                    cmd.Parameters.Add(new SqlParameter("@CategoryName", product.CategoryName));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /*
      * ********************************************************
      * Affichage d'un produit avec les differents filtres
      * ********************************************************
      * */

        public IEnumerable<Product> GetProductDB(string SearchString, string productCategory, string sortOrder)
        {
            List<Product> productList = new List<Product>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "SELECT  ProductId ,ProductName,ProductPrice,ProductReference,ProductDescription, CategoryName FROM Product JOIN Category on Category.CategoryId = Product.CategoryId ";

            //2 sortorder
            string order;
            switch (sortOrder)
            {
                case "ProductName_desc":
                    order = "order by ProductName desc";
                    break;
                case "CategoryName_asc":
                    order = "order by CategoryName";
                    break;
                case "CategoryName_desc":
                    order = "order by CategoryName desc";
                    break;
                default:
                    order = "order by ProductName";
                    break;

            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                selectSQL = selectSQL + " where ProductName like '%" + SearchString + "%'";
                if (!string.IsNullOrEmpty(productCategory))
                {
                    selectSQL = selectSQL + " and CategoryName='" + productCategory + "'";
                }
            }

            else
            {
                if (!string.IsNullOrEmpty(productCategory))
                {
                    selectSQL = selectSQL + " where CategoryName='" + productCategory + "'";
                }
            }

            // 3
            selectSQL = selectSQL + " " + order;
            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Product product = new Product();

                    product.ProductId = Convert.ToInt32(dr["ProductId"]);
                    product.ProductName = dr["ProductName"].ToString();
                    product.ProductReference = dr["ProductReference"].ToString();
                    product.ProductDescription = dr["ProductDescription"].ToString();
                    product.ProductPrice = Convert.ToInt32(dr["ProductPrice"]);
                    product.CategoryName = dr["CategoryName"].ToString();

                    productList.Add(product);
                }
            }
            con.Close();
            return productList;
        }




        /*
    * ********************************************************
    * affichage product pour Win Form API
    * ********************************************************
    * */

        public IEnumerable<Product> GetProductsDBWFApi()
        {
            List<Product> productList = new List<Product>();
            SqlConnection con = new SqlConnection(connectionString);
            string selectSQL = "SELECT  ProductId ,ProductName,ProductPrice,ProductReference, CategoryName FROM Product JOIN Category on Category.CategoryId = Product.CategoryId ";


            con.Open();
            SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Product product = new Product();

                        product.ProductId = Convert.ToInt32(dr["ProductId"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.ProductReference = dr["ProductReference"].ToString();
                        
                        product.ProductPrice = Convert.ToInt32(dr["ProductPrice"]);
                        product.CategoryName = dr["CategoryName"].ToString();


                    productList.Add(product);
                    }
                }
            con.Close();
            return productList;
            }





            /*
          * ********************************************************
          * Edition d'un produit de la page Products/edit
          * ********************************************************
          * */
            public void EditProductDB(Product product)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("USP_UpdateProduct", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ProductId", product.ProductId));
                        cmd.Parameters.Add(new SqlParameter("@ProductName", product.ProductName));
                        cmd.Parameters.Add(new SqlParameter("@ProductPrice", product.ProductPrice));
                        cmd.Parameters.Add(new SqlParameter("@ProductReference", product.ProductReference));
                        cmd.Parameters.Add(new SqlParameter("@ProductDescription", product.ProductDescription));
                        cmd.Parameters.Add(new SqlParameter("@CategoryName", product.CategoryName));
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }






        /*
         * ********************************************************
         * Afficher la liste des produits sur le winform
         * ********************************************************
         */
        
            public IEnumerable<Product> GetProductWFDB()
            {
                List<Product> productList = new List<Product>();
                SqlConnection con = new SqlConnection(connectionString);
               //string selectSQL = "SELECT  ProductId ,ProductName,ProductPrice,ProductReference,ProductDescription FROM Product";
                string selectSQL = "SELECT  * FROM ViewProduct";
                con.Open();
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        Product product = new Product();

                        product.ProductId = Convert.ToInt32(dr["ProductId"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.ProductReference = dr["ProductReference"].ToString();
                        product.ProductDescription = dr["ProductDescription"].ToString();
                        product.ProductPrice = Convert.ToInt32(dr["ProductPrice"]);
                        product.CategoryName = dr["CategoryName"].ToString();

                        productList.Add(product);
                    }
                }
            con.Close();
            return productList;
            }



            




            /*
             * ********************************************************
             * Affiche seul produit
             * ********************************************************
             * */


            public Product GetProductDB(int productId)
            {

                SqlConnection con = new SqlConnection(connectionString);

                // string selectSQL = "select ProductName,ProductPrice,ProductReference,ProductId,ProductDescription from Product where ProductId = " + productId;
                string selectSQL = "select ProductName,ProductPrice,ProductReference,ProductId,ProductDescription, CategoryName from Product join category on category.CategoryId = product.CategoryId  where ProductId = " + productId;
                con.Open();

                SqlCommand cmd = new SqlCommand(selectSQL, con);

                SqlDataReader dr = cmd.ExecuteReader();

                Product product = new Product();

                if (dr != null)
                {
                    while (dr.Read())
                    {

                        product.ProductId = Convert.ToInt32(dr["ProductId"]);
                        product.ProductName = dr["ProductName"].ToString();
                        product.ProductPrice = Convert.ToInt32(dr["ProductPrice"]);
                        product.ProductReference = dr["ProductReference"].ToString();
                        product.ProductDescription = dr["ProductDescription"].ToString();
                        product.CategoryName = dr["CategoryName"].ToString();

                    }
                }
            con.Close();
            return product;
            }
            /*
             * ********************************************************
             * Supprime un produit
             * ********************************************************
             * */
            public void DeleteProductDB(int productid)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("USP_DeleteProduct", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@ProductId", productid));


                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            /*
             * ********************************************************
             * Recupérer les categories pour la liste
             * ********************************************************
             * */


            public IEnumerable<String> GetCategoriesDB()
            {
                List<String> categoryList = new List<String>();
                SqlConnection con = new SqlConnection(connectionString);
                string selectSQL = "select CategoryName  from Category order by CategoryName ";
                con.Open();
                SqlCommand cmd = new SqlCommand(selectSQL, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        categoryList.Add(dr["CategoryName"].ToString());
                    }
                }
            con.Close();
            return categoryList;
            }















        }
    }

