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
using AppStoreBLL;
using System.Net.Http.Json;


namespace AppStoreWF
{
    public partial class ProductsInformations : Form
    {
        public ProductsInformations()
        {
            InitializeComponent();
        }
        private string connectionString = ConfigurationManager.ConnectionStrings["StoreConnection"].ConnectionString;


        private void ProductsInformations_Load(object sender, EventArgs e)
        {
            FillProductGrid();
            

        }
        private void FillProductGrid()
        {
            ProductBLL objproduct = new ProductBLL(connectionString);
            dgvProductsInfo.DataSource = objproduct.GetProductWF();
        }

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
        private void SizeDataGrid(DataGridView dg)
        {
            DataGridViewElementStates states = DataGridViewElementStates.None;
            dg.ScrollBars = ScrollBars.None;
            var totalHeight = dg.Rows.GetRowsHeight(states) + dg.ColumnHeadersHeight;
            totalHeight += dg.Rows.Count * 4;
            var totalWidth = dg.Columns.GetColumnsWidth(states) + dg.RowHeadersWidth;
            dg.ClientSize = new Size(totalWidth, totalHeight);
        }

        private void dgvProductsInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProductsInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductsInfo.AutoResizeColumns();
        }

       
    }
}
