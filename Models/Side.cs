using System.ComponentModel.DataAnnotations;

namespace burgershack.Models
{
    public class Side
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}