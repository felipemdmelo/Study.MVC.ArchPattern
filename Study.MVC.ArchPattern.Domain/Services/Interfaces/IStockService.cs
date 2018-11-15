using Study.MVC.ArchPattern.Domain.Entities;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Services.Interfaces
{
    public interface IStockService
    {
        long Insert(Stock entity);
        List<Stock> GetAll();
    }
}
