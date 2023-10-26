using shop_view.enums;
using System.ComponentModel.DataAnnotations;

namespace shop_view.Models
{
    public class Phone
    {
        [Key]
        public int PhoneID { get; set; }

        public string Brand { get; set; }
        public Category PhoneCategory { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
