using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
	public class Category
	{
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Category Name")]
        [MaxLength(15)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required (ErrorMessage ="Please Enter Display Category")]
        [Range(1,100)]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
