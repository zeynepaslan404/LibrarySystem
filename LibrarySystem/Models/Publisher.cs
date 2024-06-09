using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; } = "";
        public List<Book> Books { get; set; } = new List<Book>();
    }
}

