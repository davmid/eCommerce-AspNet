using shop_view.data;
using shop_view.data.ViewModel;
using shop_view.Models;

namespace shop_view.data.services
{
    public interface IProductService : IEntityBaseRepository<Product>
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<ProductDropdownsVM> GetNewMovieDropdonsValue();
        Task AddNewProductAsync(NewProductVM data);
        Task UpdateProductAsync(NewProductVM data);
    }
}