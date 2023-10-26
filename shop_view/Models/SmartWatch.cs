using shop_view.enums;
using System.ComponentModel.DataAnnotations;

namespace shop_view.Models
{
    public class SmartWatch
    {
        [Key]
        public int SWID { get; set; }

        public string Brand { get; set; }
        public Category SWCategory { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
