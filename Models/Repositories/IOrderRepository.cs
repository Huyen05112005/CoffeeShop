namespace CoffeeShop.Models.Repositories
{
    public interface IOrderRepository
    {
        void PlaceOrder(Order order);
    }
}
