using Study.MVC.ArchPattern.Application.Commercial.Interfaces;
using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Exceptions;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;

namespace Study.MVC.ArchPattern.Application.Commercial.Implementations
{
    public class AddProductWithStock : BaseApplication, IAddProductWithStock
    {
        private readonly IProductService _productService;
        private readonly IStockService _stockService;

        public AddProductWithStock(IProductService productService, IStockService stockService)
        {
            _productService = productService;
            _stockService = stockService;
        }

        public void Execute(Product entity)
        {
            try
            {
                // Begin Transaction..
                _productService.Insert(entity);
                _stockService.Insert(new Stock { Id = 1 });
            }
            catch(ProductException.InsertException)
            {
                // Rollback..

            }
            catch (StockException.InsertException)
            {
                // Rollback..

            }
            finally
            {
                // Commit and Dispose..

                // Notifications..
                Notify();
                Log();
            }
        }
    }
}
