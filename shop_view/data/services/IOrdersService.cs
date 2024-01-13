using shop_view.Models;

namespace shop_view.data.services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingBasketXD> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
        Task<string?> GetAllOrdersAsync();
    }
}