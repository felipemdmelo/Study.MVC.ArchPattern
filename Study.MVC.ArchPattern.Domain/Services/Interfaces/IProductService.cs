using Study.MVC.ArchPattern.Domain.Entities;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Services.Interfaces
{
    public interface IProductService
    {
        long Insert(Product entity);
        List<Product> GetAll();
    }
}
