using CleanArchitectureShop.Domain;

namespace CleanArchitectureShop.InterfaceAdapter;

public interface IAdapterInterface
{
    public List<Order> GetAllItems(string text);
}