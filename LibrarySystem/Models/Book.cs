
using System;
using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public List<Author> Authors { get; set; }
        public Publisher Publisher { get; set; }
        public List<Category> Categories { get; set; }
        public string Language { get; set; } = "";
        public string ISBN { get; set; } = "";
    }
}
