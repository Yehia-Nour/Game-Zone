using System.ComponentModel.DataAnnotations;

namespace GameZone.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [MaxLength(length: 50)]
        public string Icon { get; set; } = string.Empty;
    }
}
