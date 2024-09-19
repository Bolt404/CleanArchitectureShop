using System.Diagnostics;
using CleanArchitectureShop.Application;
using CleanArchitectureShop.Domain;

namespace CleanArchitectureShop.Domain;

public class Giftwrapping : OrderDecorater
{
    public Giftwrapping(Order order) : base(order)
    {
        if (order.Giftwrap)
        {
            Console.WriteLine("Already Wrapped");
            Description += order.Description;
            Price += order.Price;
            Giftwrap = order.Giftwrap;
        }
        else
        {
            Description = order.Description + ", GiftWrapped";
            Price = order.Price + 10;
            Giftwrap = true;
        }
    }

    public override string Id => Order.Id;
    public override string Description { get; }
    public override double Price { get; }
    public override bool Giftwrap { get; }
    public override bool Shipment => Order.Shipment;
}