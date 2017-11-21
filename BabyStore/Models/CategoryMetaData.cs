using System.ComponentModel.DataAnnotations;
namespace BabyStore.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
    }

    public class CategoryMetaData
    {
        [Required(ErrorMessage = "This field is required and cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a Category name between 3 and 50 characters in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a category name beginning with a capital letter and made up of letters and spaces only")]
        [Display(Name = "Category Name")]
        public string CategoryName;
    }
}