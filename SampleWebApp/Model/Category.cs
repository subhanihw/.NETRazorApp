using System.ComponentModel.DataAnnotations;

namespace SampleWebApp.Model
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
