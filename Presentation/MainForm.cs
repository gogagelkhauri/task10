using App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Presentation
{
    public partial class MainForm : Form
    {
        private readonly BookService _bookService;

        public MainForm(BookService bookService)
        {
            _bookService = bookService;
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            var books = await _bookService.GetBooks();
            bookDataGrid.DataSource = books;
        }

       
    }
}
