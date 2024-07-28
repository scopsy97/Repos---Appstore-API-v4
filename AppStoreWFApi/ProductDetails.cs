using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreWFApi
{
    internal class ProductDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        [DisplayName("Reference")]
        public string ProductReference { get; set; }


        [DisplayName("Description")] //permet d'afficher ce nom en titre de colonne
        public string ProductDescription { get; set; }
        public string? CategoryName { get; set; }
        public decimal ProductPrice { get; set; }

    }
}
