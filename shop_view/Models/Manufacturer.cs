using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using shop_view.data;
using shop_view.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shop_view.Models
{
    public class Manufacturer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [BindProperty]
        [Display(Name = "Manufacturer Logo")]
        [Required(ErrorMessage = "The Manufacturer Logo field is required.")]
        [RegularExpression(@"^(http|https)://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,3}(/\S*)?$", ErrorMessage = "The Manufacturer Logo must be a valid HTTP or HTTPS URL.")]
        public string CompanyLogoURL { get; set; }

        [BindProperty]
        [Display(Name = "Manufacturer Name")]
        [Required(ErrorMessage = "The Manufacturer Name field is required.")]
        public string Name { get; set; }

        [BindProperty]
        [Display(Name = "Manufacturer Description")]
        [Required(ErrorMessage = "The Manufacturer Description field is required.")]
        public string Description { get; set; }

        [ValidateNever]
        public List<Product> Products { get; set; }
    }

}