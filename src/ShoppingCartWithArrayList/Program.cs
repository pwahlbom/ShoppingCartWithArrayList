using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartWithArrayList
{
    class ShoppingCartItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ShoppingCartItem(int id, string name, decimal price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
    }

    class ShoppingCart
    {
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart()
        {
            ShoppingCartItems = new List<ShoppingCartItem>();
        }

        public void AddItem(ShoppingCartItem item)
        {
            ShoppingCartItems.Add(item);
        }

        public void RemoveItem(ShoppingCartItem item)
        {
            ShoppingCartItems.Remove(item);
        }

        public void ListItems()
        {
            foreach (var item in ShoppingCartItems)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var ShoppingCart1 = new ShoppingCart();
            var Item1 = new ShoppingCartItem(1, "razors", 15.99m);
            var Item2 = new ShoppingCartItem(2, "soap", 1.99m);


            Console.WriteLine("Add item1 and list:");
            ShoppingCart1.AddItem(Item1);
            ShoppingCart1.ListItems();
            Console.ReadLine();

            Console.WriteLine("Add item2 and list:");
            ShoppingCart1.AddItem(Item2);
            ShoppingCart1.ListItems();
            Console.ReadLine();

            Console.WriteLine("Remove item1 and list:");
            ShoppingCart1.RemoveItem(Item1);
            ShoppingCart1.ListItems();
            Console.ReadLine();
        }
    }
}