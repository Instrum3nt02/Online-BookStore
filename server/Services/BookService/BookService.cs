using server.DTO;
using server.Models.DB;
using server.Repositories.BookRepo;

namespace server.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly IBookRepo _bookrepo;

        public BookService(IBookRepo bookRepo){
            _bookrepo = bookRepo;
        }
        public async Task<Book> AddBook(BookDTO bookDTO)
        {
            Book book = new Book{
                Title = bookDTO.Title,
                PagesCount = bookDTO.PagesCount,
                Language = bookDTO.Language,
                PublisherId = bookDTO.PublisherId,
                PublishedDate = bookDTO.PublishedDate,
                PublishedVersion = bookDTO.PublishedVersion,
                Price = bookDTO.Price,
                Category = bookDTO.Category,
                Description = bookDTO.Description,
                ImageUrl = bookDTO.ImageUrl,
                AuthorName = bookDTO.Author,
            };

            return await _bookrepo.AddBook(book);
            
        }

        public async Task<bool> DeleteBook(BookDTO bookDTO)
        {
             Book book = new Book{
                Title = bookDTO.Title,
                PagesCount = bookDTO.PagesCount,
                Language = bookDTO.Language,
                PublisherId = bookDTO.PublisherId,
                PublishedDate = bookDTO.PublishedDate,
                PublishedVersion = bookDTO.PublishedVersion,
                Price = bookDTO.Price,
                Category = bookDTO.Category,
                Description = bookDTO.Description,
                ImageUrl = bookDTO.ImageUrl,
                AuthorName = bookDTO.Author,
            };
            return await _bookrepo.DeleteBook(book);
            
        }

        public async Task<List<BookDTO>> GetBookByCategory(string Category)
        {
          var books = await _bookrepo.GetBookByCategory(Category);
    
        var bookDTOs = books.Select(book => new BookDTO
         {
        Title = book.Title,
        PagesCount = book.PagesCount,
        Language = book.Language,
        PublisherId = book.PublisherId,
        PublishedDate = book.PublishedDate,
        PublishedVersion = book.PublishedVersion,
        Price = book.Price,
        Category = book.Category,
        Description = book.Description,
        ImageUrl = book.ImageUrl,
        Author = book.AuthorName
    }).ToList();
            
            return bookDTOs;    
        }

        public async Task<List<BookDTO>> GetBooks()
        {
            var books = await _bookrepo.GetBooks();
             var bookDTOs = books.Select(book => new BookDTO
         {
        Title = book.Title,
        PagesCount = book.PagesCount,
        Language = book.Language,
        PublisherId = book.PublisherId,
        PublishedDate = book.PublishedDate,
        PublishedVersion = book.PublishedVersion,
        Price = book.Price,
        Category = book.Category,
        Description = book.Description,
        ImageUrl = book.ImageUrl,
        Author = book.AuthorName
    }).ToList();
            
            return bookDTOs;    

        }

        public async Task<List<string>> GetCategories()
        {
            return await _bookrepo.GetCategories();
        }
    }
}