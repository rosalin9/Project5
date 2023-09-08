using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingSystem
{
    public class Product
    {
        public string Name;
        public int Price;
        public string Category;
        

        public Product(string name, int price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
        
    }
    public class ElectronicProduct : Product
    {
        int Warrenty;
        public ElectronicProduct(string name, int price, string category,int warrenty) : base(name,price,category)
        {
            Warrenty = warrenty;
            
        }
    }
    public class ClothingProduct : Product
    {
        int Size;
        public ClothingProduct(string name, int price, string category,int size) : base(name,price,category) 
        {
            Size = size;
            
        }
    }
}
