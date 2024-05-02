using BookAPI.Dto;
using System.Collections.Generic;

namespace BookAPI.Services
{
    public class BooksServices(AppDbContext context)
    {

        private AppDbContext _context = context;

        public List<Models.Book> GetAllBooks()
        {
            var allBooks = _context.Books.ToList();
            return allBooks;
        }

        public Models.Book AddBook(PostBookDto student)
        {
            var newBook = new Models.Book()
            {
            };

            _context.Books.Add(newBook);
            _context.SaveChanges();

            return newBook;
        }

        public void DeleteBook(int id)
        {
            var bookDb = _context.Books
                .FirstOrDefault(n => n.Id == id);

            _context.Books.Remove(bookDb);
            _context.SaveChanges();
        }



        public Models.Book GetBookById(int id)
        {
            var newBook = _context.Books
                .FirstOrDefault(n => n.Id == id);

            return newBook;
        }

        public Models.Book UpdateBook(PutBookDto bookData, int id)
        {
            var bookDb = _context.Books
                .FirstOrDefault(n => n.Id == id);

            bookDb.Title = bookData.Title;
            _context.Books.Update(bookDb);

            _context.SaveChanges();

            return bookDb;
        }
    }


}


