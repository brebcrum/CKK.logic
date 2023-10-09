using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreys_knick_knacks
{
    internal class ShoppingCartItem
    {
        private Product product;
        private int quantity;

        public Product Product
        {
            set { product = value; }
            get { return product; }
        }

        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }
    }
}
