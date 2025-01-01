﻿namespace GameZone.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
