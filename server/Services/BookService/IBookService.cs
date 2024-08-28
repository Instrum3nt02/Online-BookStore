using server.DTO;
using server.Models.DB;

namespace server.Services.BookService {
    public interface IBookService {

        Task<Book> AddBook(BookDTO bookDTO);

        Task<List<string>> GetCategories();

        Task<List<BookDTO>> GetBookByCategory(String Category);

        Task<bool> DeleteBook(BookDTO bookDTO);

        Task<List<BookDTO>> GetBooks();
    }
}