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
    }

    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }

    public class Reviewer
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
    }

    public class BookReview
    {
        public int Id { get; set; }
        public int ScoreOn5Scale { get; set; }
        public string ReviewTitle { get; set; }
        public string DetailedReview { get; set; }
    }
}
