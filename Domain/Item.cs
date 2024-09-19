namespace CleanArchitectureShop.Domain
{
    public class Item : Order
    {
        public override string Id { get; }
        public override string Description { get; }
        public override double Price { get; }

        public override bool Giftwrap { get; }
        
        public override bool Shipment { get; }

        public Item(string id, string description, double price)
        {
            Id = id;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return Id + ", " + Description + ", " + Price;
        }
    }
}
