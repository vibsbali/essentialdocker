using System.Linq;

namespace exampleapp.Models
{
    public interface IRepository
    {
         IQueryable<Product> Products {get;}
    }
}