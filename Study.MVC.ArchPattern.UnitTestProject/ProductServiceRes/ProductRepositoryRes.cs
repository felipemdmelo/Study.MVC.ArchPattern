using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Repositories.Interfaces;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.UnitTestProject.ProductServiceRes
{
    public class ProductRepositoryRes : IProductRepository
    {
        public List<Product> GetAll()
        {
            var rtn = new List<Product>();
            rtn.Add(new Product
            {
                Name = "Ar Condicionado",
                Price = 899.90
            });

            rtn.Add(new Product
            {
                Name = "Cadeira de Escritório",
                Price = 349.90
            });

            return rtn;
        }

        public long Insert(Product entity)
        {
            return 1;
        }
    }
}
