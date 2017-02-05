using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Gamely.Models;

namespace Gamely.Dtos
{
    public class GamesDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string ReleaseDate { get; set; }

        public string DateAdded { get; set; }
        
        [Range(1, 20, ErrorMessage = "The number should be between 1 and 20.")]
        public int NumberInStock { get; set; }
        
       public short GenreId { get; set; }
    }
}