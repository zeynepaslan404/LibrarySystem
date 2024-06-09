using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models;

namespace LibrarySystem.Data
{
    public class LibrarySystemContext : DbContext
    {
        public LibrarySystemContext (DbContextOptions<LibrarySystemContext> options)
            : base(options)
        {
        }

        public DbSet<LibrarySystem.Models.Book> Book { get; set; } = default!;
        public DbSet<LibrarySystem.Models.Author> Author { get; set; } = default!;
        public DbSet<LibrarySystem.Models.Category> Category { get; set; } = default!;
        public DbSet<LibrarySystem.Models.Employee> Employee { get; set; } = default!;
        public DbSet<LibrarySystem.Models.Member> Member { get; set; } = default!;
        public DbSet<LibrarySystem.Models.Publisher> Publisher { get; set; } = default!;
    }
}
