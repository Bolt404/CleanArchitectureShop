using System.Diagnostics;
using CleanArchitectureShop.Application;

namespace CleanArchitectureShop.Domain;

public class Shipping : OrderDecorater
{
    public Shipping(Order order) : base(order)
    {
        if (order.Shipment)
        {
            Console.WriteLine("Shipment Already Ordered.");
            Description += order.Description;
            Price += order.Price;
            Shipment = order.Shipment;


        }
        else
        {
            Description = order.Description + ", Shipment";
            Price = order.Price + 10;
            Shipment = true;
        }
    }

    public override string Id => Order.Id;
    public override string Description { get; }
    public override double Price { get; } 
    public override bool Giftwrap => Order.Giftwrap;
    public override bool Shipment { get; }
}