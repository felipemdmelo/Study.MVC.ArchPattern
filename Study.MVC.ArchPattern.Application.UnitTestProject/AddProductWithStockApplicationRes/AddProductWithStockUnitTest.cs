using Microsoft.VisualStudio.TestTools.UnitTesting;
using Study.MVC.ArchPattern.Application.Commercial.Implementations;
using Study.MVC.ArchPattern.Application.Commercial.Interfaces;
using Study.MVC.ArchPattern.Domain.Entities;
using System;

namespace Study.MVC.ArchPattern.Application.UnitTestProject.AddProductWithStockApplicationRes
{
    [TestClass]
    public class AddProductWithStockUnitTest
    {
        [TestMethod]
        public void InsertValid()
        {
            try
            {
                var productServiceRes = new ProductServiceRes();
                var stockServiceRes = new StockServiceRes();

                IAddProductWithStock app = new AddProductWithStock(productServiceRes, stockServiceRes);
                app.Execute(new Product
                {
                    Name = "Produto 1",
                    Price = 1.99
                });

                Assert.IsTrue(productServiceRes.InsertCalled);
                Assert.IsTrue(stockServiceRes.InsertCalled);
            }
            catch (Exception)
            {
                Assert.Fail("Não era pra ter sido lançada nenhuma exceção!");
            }
        }
    }
}
