using Study.MVC.ArchPattern.Domain.Entities;
using System.Collections.Generic;

namespace Study.MVC.ArchPattern.Domain.Repositories.Interfaces
{
    public interface IStockRepository
    {
        long Insert(Stock entity);
        List<Stock> GetAll();
    }
}
