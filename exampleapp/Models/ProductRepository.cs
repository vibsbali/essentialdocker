using System.Linq;

namespace exampleapp.Models
{
    public class ProductRepository : IRepository
    {
        private ProductDbContext context;
        public ProductRepository(ProductDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
    }
}