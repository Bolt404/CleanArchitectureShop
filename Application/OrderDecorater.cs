using CleanArchitectureShop.Domain;

namespace CleanArchitectureShop.Application;

public abstract class OrderDecorater : Order
{
    protected Order Order;

    public OrderDecorater(Order order)
    {
        this.Order = order;
    }
}