using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSystem
{
    public class ShoppingCart
    {
        public Product products;
        public int Quantity;

        public ShoppingCart(Product product, int quantity)
        {
            products = product;
            Quantity = quantity;
        }
        
    }
}
