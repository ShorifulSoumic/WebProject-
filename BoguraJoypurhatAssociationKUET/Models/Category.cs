using System.ComponentModel.DataAnnotations;

namespace BoguraJoypurhatAssociationKUET.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Roll { get; set; }

        [Required]
        public string Dept { get; set; }
    }
}
