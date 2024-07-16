using BookStore.Models;

namespace BookStore.Services
{
    public class MockBookRepostory : IBookRepository
    {

        private List<Book> bookList;

        public MockBookRepostory() 
        {
            bookList = new List<Book>()
            {
                new Book{Id=1,Title = "Deep Work", Author= "Agrim Jain", Description="How to work with Focus",Language = Language.English},
                new Book{Id=2,Title = "Bitcoin", Author= "Suzuki Nakamato", Description="How does Bitcoin work",Language = Language.English}
            };

        }
        
        public Book Create(Book entity)
        {
            var id = bookList.Max(x => x.Id);
            entity.Id = id+1;
            bookList.Add(entity);
            return entity;
        }

        public Book Delete(int? id)
        {
            var book = bookList.Find(x => x.Id == id);
            bookList.Remove(book);
            return book;
        }

        public Book Get(int? id)
        {
            return bookList.Find(x => x.Id == id);
        }

        public List<Book> GetAll()
        {
            return bookList;
        }

        public Book Update(Book entity)
        {
            var book = bookList.Find(x => x.Id == entity.Id);
            book.Title = entity.Title;
            book.Author = entity.Author;
            book.Description = entity.Description;
            book.Language = entity.Language;
            return book;
        }
    }
}
