using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.EFCore.Demo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Edition { get; set; }
        public double Price { get; set; }
        public int NPages { get; set; }
        public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        public Publisher Publisher { get; set; }
        public ICollection<BookReview> Reviews { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }

    public class Reviewer
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public ICollection<BookReview> Reviews { get; set; } = new List<BookReview>();
    }

    public class BookReview
    {
        public int Id { get; set; }
        public int ScoreOn5Scale { get; set; }
        public string ReviewTitle { get; set; }
        public string DetailedReview { get; set; }
        public Book Book { get; set; }
        public Reviewer Reviewer { get; set; }
    }
}
