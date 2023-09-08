using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSystem
{
    public class Program
    {
        static List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();

        static void AddToCart()
        {
            Console.Write("Enter the product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the price of the product: ");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the quantity of the product: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the category of the product: ");
            string category = Console.ReadLine();
            if (category == "Electronic")
            {
                Console.Write("Enter the warrenty of the product: ");
                int warrenty = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.Write("Enter the size of the product: ");
                int size = Convert.ToInt32(Console.ReadLine());
            }
            Product product = new Product(name, price, category);
            ShoppingCart cart = new ShoppingCart(product, quantity);
            shoppingCarts.Add(cart);
        }
        static void TotalPrice()
        {
            int total =0;
            foreach(ShoppingCart cart in shoppingCarts) 
            {
                total += cart.products.Price * cart.Quantity;
            }
            Console.Write("Total price of your cart : " + total);
            Console.WriteLine();
        }
        static void DisplayCart()
        {
            Console.WriteLine("Product      Quantity");
            Console.WriteLine("----------------------");
            foreach(ShoppingCart cart in shoppingCarts) 
            {
                Console.Write("{0,-20}",cart.products.Name);
                Console.WriteLine(cart.Quantity);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add to Cart");
            Console.WriteLine("2. Display Cart");
            Console.WriteLine("3. Total Bill");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            int op;
            do
            {
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:

                        AddToCart();
                        break;
                    case 2:
                        DisplayCart();
                        break;
                    case 3:
                        TotalPrice(); 
                        break;
                }
            } while (op > 0 && op < 4);
            
        }
    }
}
