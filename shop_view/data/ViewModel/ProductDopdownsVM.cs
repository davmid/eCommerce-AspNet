using shop_view.Models;

namespace shop_view.data.ViewModel
{
    public class ProductDropdownsVM
    {
        public ProductDropdownsVM()
        {
            Manufacturers = new List<Manufacturer>();
        }
        public List<Manufacturer> Manufacturers { get; set; }
    }
}