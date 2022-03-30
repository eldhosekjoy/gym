using System.ComponentModel.DataAnnotations;

namespace GymStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
    }
}
