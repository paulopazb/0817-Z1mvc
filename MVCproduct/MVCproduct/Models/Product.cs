using System.ComponentModel.DataAnnotations;

namespace MVCproduct.Models
{
    public class Product
    {
        [key]

        public int productID { get; set; }
        [Required]
        [Display(Description ="Product Name")]
        public string Name{ get; set; }
        public string Description { get; set; }



    }
}