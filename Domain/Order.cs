namespace CleanArchitectureShop.Domain;

public abstract class Order
{
    public abstract string Id { get; }
    
    public abstract string Description { get; }
    
    public abstract double Price { get; }
    
    public abstract bool Giftwrap { get;  }
    
    public abstract bool Shipment { get;  }
    
}