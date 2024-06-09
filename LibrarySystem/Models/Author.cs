﻿using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = "";
        public List<Book> Books { get; set; } = new List<Book>();
    }
}
