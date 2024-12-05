using BookCatalogApp.Models;
using WAD._00016004.Repositories;

namespace WAD._00016004.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        //00016004
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        //00016004
        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return await _bookRepository.GetAllBooksAsync();
        }
        //00016004
        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _bookRepository.GetBookByIdAsync(id);
        }
        //00016004
        public async Task AddBookAsync(Book book)
        {
            await _bookRepository.AddBookAsync(book);
        }
        //00016004
        public async Task UpdateBookAsync(Book book)
        {
            await _bookRepository.UpdateBookAsync(book);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _bookRepository.DeleteBookAsync(id);
        }
    }//00016004
}
