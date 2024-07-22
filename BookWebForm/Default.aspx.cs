using BookWebForm.App_Code.Interface;
using BookWebForm.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI;
using Unity;

namespace BookWebForm
{
    public partial class _Default : Page
    {
        private IBookService _bookService;

        protected async void Page_Load(object sender, EventArgs e)
        {
            _bookService = ((Global)Context.ApplicationInstance).GetUnityContainer().Resolve<IBookService>();
            if (!IsPostBack)
            {
                await LoadBooksAsync();
            }
        }

        private async Task LoadBooksAsync()
        {
            try
            {
                List<Book> books = await _bookService.GetAllBooksAsync();
                GridViewBooks.DataSource = books;
                GridViewBooks.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        protected async void btnLoadBook_Click(object sender, EventArgs e)
        {
            await LoadBooksAsync();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Button Clicked!";
        }

        protected async void btnSearchBook_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtSearch.Text);
                Book books = await _bookService.GetBookByIdAsync(id);
                GridViewBooks.DataSource = new List<Book> { books };
                GridViewBooks.DataBind();
            }
            catch (Exception ex)
            {

            }
        }
    }
}