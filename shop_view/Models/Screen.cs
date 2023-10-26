using shop_view.enums;
using System.ComponentModel.DataAnnotations;

namespace shop_view.Models
{
    public class Screen
    {
        [Key]
        public int ScreenID { get; set; }

        public string Brand { get; set; }
        public Category ScreenCategory { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Inches { get; set; }
    }
}
