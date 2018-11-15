using Study.MVC.ArchPattern.Application.Commercial.Interfaces;
using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Application.Commercial.Implementations
{
    public class GetProduct : BaseApplication, IGetProduct
    {
        private readonly IProductService _productService;

        public GetProduct(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> GetAll()
        {
            // Notifications..
            Notify();
            Log();
            return _productService.GetAll();
        }
    }
}
