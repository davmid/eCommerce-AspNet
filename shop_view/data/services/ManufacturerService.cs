using shop_view.data;
using shop_view.Models;

namespace shop_view.data.services
{
    public class ManufacturerService : EntityBaseRepository<Manufacturer>, IManufacturerService
    {
        public ManufacturerService(shopDbContext context) : base(context) { }
    }
}