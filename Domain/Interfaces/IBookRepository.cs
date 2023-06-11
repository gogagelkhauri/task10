using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        //void UpdateBook(Book book);
        //Task<IEnumerable<Book>> GetBooksByAuthor(int skip, int take, string author);
        Task<IEnumerable<Book>> GetAllBooks();
        //Task<int> GetAllBooksCount();
        //Task<int> GetBooksByAuthorCount(string author);
    }
    
}
