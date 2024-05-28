using Entities;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<List<Product>> Get(string? description, int? minPrice, int? maxPrice, string? name, int?[] categoryIds, int position = 20, int skip = 1)
        {
            List<Product> result = await productRepository.Get(description, minPrice, maxPrice, name, categoryIds, position, skip);
            return result;
        }

        public async Task<List<Product>> Get()
        {
            return await productRepository.Get();
        }
    }
}