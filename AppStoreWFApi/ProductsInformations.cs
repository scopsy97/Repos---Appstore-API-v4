using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
//using AppStoreBLL;
using System.Net.Http.Json;
using Newtonsoft.Json;


//using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Windows.Input;
using System.Security.Policy;


namespace AppStoreWFApi
{
    public partial class ProductsInformations : Form
    {
        public ProductsInformations()
        {
            InitializeComponent();
        }
        //private string connectionString = ConfigurationManager.ConnectionStrings["StoreConnection"].ConnectionString;

        string URL = "http://localhost:5000/api/Product"; // URL pour contacter le controleur de l'API
        private int productId = 0;
        private HttpClient client = new HttpClient();
        private void ProductsInformations_Load(object sender, EventArgs e)
        {

            CallWebAPI(this.URL);

        }

        // change la couleur de fond
        private void lblProductsInfo_Click(object sender, EventArgs e)
        {
            ChangeBackgroundColor();

        }
        private void ChangeBackgroundColor()
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            this.BackColor = randomColor;
        }
   
        // Get API
        private async void CallWebAPI(string URL)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();
                        dgvProductsInfo.DataSource = JsonConvert.DeserializeObject<List<Product>>(productJsonString);

                    }
                    else
                    {
                        MessageBox.Show("Pas de produit à afficher !");
                    }
                }
            }
        }


        //Recuperation de productId via le tableau
        private void dgvProductsInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            productId = Convert.ToInt32(dgvProductsInfo.Rows[e.RowIndex].Cells[0].Value.ToString());

           

        }



        //API Get(ID)
        private async void fillCProductDetails(int productId)
        {

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URL + "/" + productId))

                {
                    if (response.IsSuccessStatusCode)
                    {
                        var productJsonString = await response.Content.ReadAsStringAsync();
                        var productdetails = JsonConvert.DeserializeObject<ProductDetails>(productJsonString);

                        // Met le produit dans une liste
                        var productDetailsList = new List<ProductDetails> { productdetails };

                        // Assignez la liste au DataGridView
                        dgvDetails.DataSource = productDetailsList;

                        // affichage du details dans les labels
                        lblProdName.Text = productdetails.ProductName;
                        lblProdRef.Text = productdetails.ProductReference;
                        lblProdDesc.Text = productdetails.ProductDescription;

                        lblCatName.Text = productdetails.CategoryName;
                        lblProdPrice.Text =Convert.ToString(productdetails.ProductPrice);


                    }
                    else
                    {
                        MessageBox.Show("Pas de details à afficher !");
                    }
                }
            }


        }

 


        private void btnDetails_Click(object sender, EventArgs e)
        {

            if (productId != 0)
            {

                fillCProductDetails(productId);

            }
            else
            {
                MessageBox.Show("Selectionner un produit");
            }

        }
    }
}
