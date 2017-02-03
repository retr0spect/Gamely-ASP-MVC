using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gamely.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Release Date")]
        [Required]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20, ErrorMessage = "The number should be between 1 and 20.")]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        public short GenreId { get; set; }
    }
}