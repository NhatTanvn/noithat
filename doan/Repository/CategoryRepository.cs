using DoAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn.Repository
{
    public class CategoryRepository
    {
        private MainDbContext db = new MainDbContext();

        public CategoryRepository(MainDbContext _dbContext)
        {
            db = _dbContext;
        }
        public CategoryRepository()
        {
            db = new MainDbContext();
        }
        public List<Category> getAllCategories()
        {
            return db.Categories.ToList();
        }
    }
}
