using BookStore.Models;
using BookStore.Services;

namespace BookStore.Data
{
    public class BookSQLRepository : IBookRepository
    {
        private readonly BookContext bookContext;

        //constructor injection to inject the DB context object
        public BookSQLRepository(BookContext context) {
            this.bookContext = context;
        }
        public Book Create(Book book)
        {
            bookContext.Books.Add(book);
            bookContext.SaveChanges();
            return book;
        }

        public Book Delete(int? id)
        {
            var book = bookContext.Books.FirstOrDefault(x=>x.Id == id);
            bookContext.Books.Remove(book);
            bookContext.SaveChanges();
            return book;
        }

        public Book Get(int? id)
        {
            return bookContext.Books.Find(id);
        }

        public List<Book> GetAll()
        {
            return bookContext.Books.ToList();
        }

        public Book Update(Book entity)
        {
            var bookToUpdate = bookContext.Books.Find(entity.Id);
            //bookContext.Books.Remove(entity);
            return entity;
        }
    }
}
