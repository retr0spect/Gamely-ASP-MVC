﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gamely.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public string DateAdded { get; set; }
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }
        public short GenreId { get; set; }
    }
}