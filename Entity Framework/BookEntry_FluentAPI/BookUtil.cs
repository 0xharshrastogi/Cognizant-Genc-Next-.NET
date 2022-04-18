using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1              //DO NOT change the namespace name
{
    public class BookUtil         //DO NOT change the class name 
    {

        public Book AddBook(Book book)    //DO NOT change the method Name and Signature
        {
            using (var db = new LibraryContext())
            {
                var b = db.Books.Add(book);
                db.SaveChanges();
                return b;
            }
        }


        public List<Book> GetBookByGenre(String Genre)   //DO NOT change the method Name and Signature
        {
            using (var db = new LibraryContext())
            {
                var books = db.Books.Where(b => b.BookGenre == Genre);
                return books.ToList();
            }
        }

        public List<Book> GetBooksList() //DO NOT change the method Name and Signature
        {
            using (var db = new LibraryContext())
            {
                var books = db.Books;
                return books.ToList();
            }

        }
        public Book UpdateBookPrice(int NewPrice, int Bookid)   //DO NOT change the method Name and Signature
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.Single(b => b.BookId == Bookid);
                book.BookPrice = NewPrice;
                db.SaveChanges();
                return book;
            }

        }

        public Book DeleteBook(int BookId)  //DO NOT change the method Name and Signature
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.Single(b => b.BookId == BookId);
                var delBooks = db.Books.Remove(book);
                db.SaveChanges();
                return delBooks;
            }
        }

    }
}
