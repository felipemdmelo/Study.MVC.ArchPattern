using System.Collections.Generic;
using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;

namespace Study.MVC.ArchPattern.Application.UnitTestProject.AddProductWithStockApplicationRes
{
    public class ProductServiceRes : IProductService
    {
        public bool InsertCalled { get; set; }
        public bool GetAllCalled { get; set; }

        public List<Product> GetAll()
        {
            GetAllCalled = true;
            return null;
        }

        public long Insert(Product entity)
        {
            InsertCalled = true;
            return 1;
        }
    }
}
