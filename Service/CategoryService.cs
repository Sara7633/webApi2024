using Entities;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> GetAllCategories()
        {
            List<Category> res = await categoryRepository.GetAllCategories();
            return res;
        }
    }
}