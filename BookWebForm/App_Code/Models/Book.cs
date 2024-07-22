using System.Collections.Generic;

namespace BookWebForm.App_Code.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string Isbn { get; set; }
        public int PageCount { get; set; }
        public List<string> Authors { get; set; }
    }
}