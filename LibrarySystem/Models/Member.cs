using System;
using System.Collections.Generic;

namespace LibrarySystem.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public DateTime MembershipDate { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}
