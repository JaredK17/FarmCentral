using System;
using ST10090287_ProgPart2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST10090287_ProgPart2.Models
{
    public class Product
    {
        public string PRODUCT_ID { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string PRODUCT_PRICE { get; set; }
        public string PRODUCT_QTY { get; set; }
        public string FARMER_ID { get; set; }

        public Product()
        {
        }

        public Product(string pRODUCT_ID, string pRODUCT_TYPE, string pRODUCT_PRICE, string pRODUCT_QTY, string fARMER_id)
        {
            PRODUCT_ID = pRODUCT_ID;
            PRODUCT_TYPE = pRODUCT_TYPE;
            PRODUCT_PRICE = pRODUCT_PRICE;
            PRODUCT_QTY = pRODUCT_QTY;
            FARMER_ID = fARMER_id;
           
        }
    }
}
