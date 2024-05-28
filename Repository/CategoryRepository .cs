using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly _214346710DbContext categoryContext;

        public CategoryRepository(_214346710DbContext categoryContext)
        {
            this.categoryContext = categoryContext;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            return await categoryContext.Categories.ToListAsync();
        }
    }
}