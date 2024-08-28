using server.Models.DB;

namespace server.Repositories.BookRepo
{
    public interface IBookRepo
    {
        public  Task<Book> AddBook(Book book);
        public Task<List<string>> GetCategories();

        public Task<List<Book>> GetBookByCategory(String Category);

        public Task<bool> DeleteBook(Book book);

        public Task<List<Book>> GetBooks();
    }
}