using Study.MVC.ArchPattern.Domain.Entities;
using Study.MVC.ArchPattern.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Application.UnitTestProject.AddProductWithStockApplicationRes
{
    public class StockServiceRes : IStockService
    {
        public bool InsertCalled { get; set; }
        public bool GetAllCalled { get; set; }

        public List<Stock> GetAll()
        {
            GetAllCalled = true;
            return null;
        }

        public long Insert(Stock entity)
        {
            InsertCalled = true;
            return 1;
        }
    }
}
