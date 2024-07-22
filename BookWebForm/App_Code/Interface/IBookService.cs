using BookWebForm.App_Code.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookWebForm.App_Code.Interface
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task<List<Book>> GetBooksByTitleAsync(string title);
        Task<List<Book>> GetBooksByAuthorAsync(string author);
    }
}
