using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyStore.Models
{
    [MetadataType(typeof(ProductImageMetaData))]
    public partial class ProductImage
    {
    }
    public class ProductImageMetaData
    {
        public int ID;
        [Display(Name = "File")]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string FileName;
    }
}