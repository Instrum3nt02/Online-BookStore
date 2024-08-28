using Microsoft.EntityFrameworkCore;
using server.Models.DB;


namespace server.Repositories.BookRepo
{
    public class BookRepo : IBookRepo
    {
        private readonly BookStoreDbContext _context;

        public BookRepo(BookStoreDbContext context)
        {
            _context = context;
        }
        
        public async Task<Book> AddBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task<bool> DeleteBook(Book book)
        {
        
{
    var books = await _context.Books.FirstOrDefaultAsync(b => b.Title == book.Title);
    if (books == null)
    {
        return false;
    }

    _context.Books.Remove(books);
    await _context.SaveChangesAsync();
    return true;
}


        }

        public async Task<List<Book>> GetBookByCategory(string Category)
        {
            var books = await _context.Books
                                    .Where(b => b.Category == Category)
                                    .ToListAsync();
            return books;
        }

        public async Task<List<Book>> GetBooks()
        {
            var books = await _context.Books.ToListAsync();
            return books;
        }

        public async Task<List<string>> GetCategories()
        {
        return  await _context.Books
                            .Select(b => b.Category)
                            .Distinct()
                            .ToListAsync();               

        }
    }

}