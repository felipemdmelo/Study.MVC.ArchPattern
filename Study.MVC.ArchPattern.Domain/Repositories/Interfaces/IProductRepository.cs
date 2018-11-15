using Study.MVC.ArchPattern.Domain.Entities;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        long Insert(Product entity);
        List<Product> GetAll();
    }
}
