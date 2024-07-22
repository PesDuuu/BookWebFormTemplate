using BookWebForm.App_Code.Interface;
using BookWebForm.App_Code.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BookWebForm.App_Code.Service
{
    public class BookService : IBookService
    {
        private readonly string apiUrl = "https://softwium.com/api/books";

        public async Task<List<Book>> GetAllBooksAsync()
        {
            using (WebClient wc = new WebClient())
            {
                try
                {
                    string json = await wc.DownloadStringTaskAsync(apiUrl);
                    List<Book> books = JsonConvert.DeserializeObject<List<Book>>(json);
                    return books;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching books from API.", ex);
                }
            }
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            string apiUrlById = $"{apiUrl}/{id}";
            using (WebClient wc = new WebClient())
            {
                try
                {
                    string json = await wc.DownloadStringTaskAsync(apiUrlById);
                    Book book = JsonConvert.DeserializeObject<Book>(json);
                    return book;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error fetching book with ID {id} from API.", ex);
                }
            }
        }

        public Task<List<Book>> GetBooksByAuthorAsync(string author)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetBooksByTitleAsync(string title)
        {
            throw new NotImplementedException();
        }
    }
}