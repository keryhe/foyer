using System;
using System.ComponentModel.DataAnnotations;

namespace Foyer.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }
    }
}
