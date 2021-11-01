using System;
using System.ComponentModel.DataAnnotations;

namespace Foyer.Data.Models
{
    public class Tile
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(32)]
        public string Title { get; set; }

        [MaxLength(128)]
        public string Description { get; set; }

        [MaxLength(256)]
        public string Link { get; set; }

        public Category Category { get; set; }
    }
}
