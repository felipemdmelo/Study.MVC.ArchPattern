using Microsoft.VisualStudio.TestTools.UnitTesting;
using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Exceptions;
using Study.MVC.ArchPattern.Domain.Services.Implementations;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;
using System;

namespace Study.MVC.ArchPattern.UnitTestProject.ProductServiceRes
{
    [TestClass]
    public class ProductServiceUnitTest
    {
        [TestMethod]
        public void InsertWithId()
        {
            try
            {
                IProductService service = new ProductService(new ProductRepositoryRes());
                service.Insert(new Product
                {
                    Id = 1,
                    Name = "Produto 1",
                    Price = 1.99
                });
                Assert.Fail("Era pra ter sido lançada uma exceção!");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is ProductException.InsertException);
            }
        }

        [TestMethod]
        public void InsertWithNoName()
        {
            try
            {
                IProductService service = new ProductService(new ProductRepositoryRes());
                service.Insert(new Product
                {
                    Price = 1.99
                });
                Assert.Fail("Era pra ter sido lançada uma exceção!");
            }
            catch(Exception e)
            {
                Assert.IsTrue(e is ProductException.InsertException);
            }
        }

        [TestMethod]
        public void InsertWithInvalidPrice()
        {
            try
            {
                IProductService service = new ProductService(new ProductRepositoryRes());
                service.Insert(new Product
                {
                    Name = "Produto 1",
                    Price = -2
                });
                Assert.Fail("Era pra ter sido lançada uma exceção!");
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is ProductException.InsertException);
            }
        }

        [TestMethod]
        public void InsertValid()
        {
            try
            {
                IProductService service = new ProductService(new ProductRepositoryRes());
                var rtn = service.Insert(new Product
                {
                    Name = "Produto 1",
                    Price = 1.99
                });
                Assert.IsTrue(rtn > 0);
            }
            catch (Exception)
            {
                Assert.Fail("Era pra ter sido lançada uma exceção!");
            }
        }
    }
}
