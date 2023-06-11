using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Book>> GetAllBooks() =>
            await _dbContext.Books
                .ToListAsync();
    }
}
