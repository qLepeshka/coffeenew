using CoffeeNew.Data;
using CoffeeNew.Models.Entities;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace CoffeeNew.Repositories
{
    public class NewsRepository
    {
        private ApplicationDbContext _context;

        public NewsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<News>> GetNewsAsync()
        {

            return await _context.News.ToListAsync();

        }
    }
}
