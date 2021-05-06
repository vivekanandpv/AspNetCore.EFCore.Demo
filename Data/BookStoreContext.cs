using AspNetCore.EFCore.Demo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.EFCore.Demo.Data
{
    public class BookStoreContext : DbContext
    {
        //  In csproj file, add this under PropertyGroup: <GenerateRuntimeConfigurationFiles>True</GenerateRuntimeConfigurationFiles>
        //  from command prompt run: dotnet ef migrations add Init
        //  then, run: dotnet ef database update
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }
    }
}
