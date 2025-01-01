using System.ComponentModel.DataAnnotations;

namespace GameZone.Models
{
    public class Game
    {
        public int Id { get; set; }

        [MaxLength(length:250)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(length:2500)]
        public string Description { get; set; } = string.Empty;
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<GameDevice> Devices { get; set; } = new List<GameDevice>();
    }
}
