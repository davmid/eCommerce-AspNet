using System.ComponentModel.DataAnnotations;

namespace shop_view.Models
{
    public class ShoppingBasketXD
    {
        [Key]
        public int Id { get; set; }

        public Product Product { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

    }
}