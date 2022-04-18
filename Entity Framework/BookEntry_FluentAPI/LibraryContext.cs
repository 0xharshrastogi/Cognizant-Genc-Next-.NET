using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Exercise1                      //DO NOT change the namespace name
{
    class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public LibraryContext() : base("name=BookStore") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Book>()
                .ToTable("BookDetail");

            modelBuilder
                .Entity<Book>()
                .Property(b => b.BookId)
                .HasColumnName("Book_Id");
        }
    }
}
