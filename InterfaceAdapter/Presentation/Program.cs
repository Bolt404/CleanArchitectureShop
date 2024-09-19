// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using CleanArchitectureShop.Domain;
using CleanArchitectureShop.Infrastructur.Adapters;

namespace MyNamespace
{
    class Program()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start");
            List<Order> items = new List<Order>();
            List<Order> giftwrap = new List<Order>();
            List<Order> shipping = new List<Order>();

            // lav en instans af FileItemRepos // Hedder ItemTxtFileApdater nu. (husk stien til filerne)
            // List<Item> items = "kald metoden i use case #1 for at hente alle items" 
            items = new ItemTxtFileAdapter().GetAllItems("C:\\Users\\Mads\\RiderProjects\\CleanArchitectureShop\\Resources\\ItemFiles\\items.txt");
            giftwrap = new ItemTxtFileAdapter().GetAllItems("C:\\Users\\Mads\\RiderProjects\\CleanArchitectureShop\\Resources\\GiftingFiles\\wrapping.txt");
            shipping = new ItemTxtFileAdapter().GetAllItems("C:\\Users\\Mads\\RiderProjects\\CleanArchitectureShop\\Resources\\ShippingFiles\\shipping.txt");


            // lav en instans af use case #1..
            Console.WriteLine("ITEMS FOR SALE");
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("TYPES OF GIFTWRAP");
            foreach (var item in giftwrap)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("TYPES OF SHIPPING");
            foreach (var item in shipping)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(" ");
            
            //Lad os "Købe" et item.
            Order purchased = items[0];
            Console.WriteLine($"New Purchase: {purchased.Description} | Price: {purchased.Price}");
            
            //Gift Wrap det item.
            purchased = new Giftwrapping(purchased);
            Console.WriteLine($"GiftWrapped: {purchased.Description} | Price: {purchased.Price}");
            
            //Shipping
            purchased = new Shipping(purchased);
            Console.WriteLine($"GiftWrapped: {purchased.Description} | Price: {purchased.Price}");
            




            Console.Read();
        }
        
    }
    
}

